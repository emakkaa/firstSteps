  function solve(){            

        var Item,Validator,Book,Media,Catalog , BookCatalog , MediaCatalog;

        Validator = {
            validateString(value,min,max){
                if(typeof value !== "string"){
                    throw new Error("ISKAM STRING BE!");
                }

                if(value.length < min || value.length > max){
                    throw new Error(`${value} must be between ${min} and ${max}`);
                }
            },
            validateNumber(value,min,max){
                if(+value < +min || +value > +max){
                    throw new Error(`Value must be between ${min} && ${max}`);
                }
            },

            validateIsbn(isbn){
                isbn = "" + isbn;
                if(isbn.length=== 10 || isbn.length === 13){
                    if(!isbn.match(/\d+/)){
                        throw new Error('Invalid isbn');
                    }
                } else{
                    throw new Error('Invalid isbn');
                }

            },
            validateNumberGreaterThanZero(value){
                if(!(value > 0)){
                    throw new Error('The number should be bigger than 0');
                }
            },
            validateIfItIsItem(item){
                if(!item.id || !item.description || !item.name){
                    throw new Error('It is not itemlike.');
                }
            }

        };

        Item = (function(){
            var uniqueId = 0;

            class Item {
                constructor(name,description){
                    this._id = (uniqueId+=1);
                    this.name = name;
                    this.description = description;
                }

                get id(){
                    return this._id;
                }

                get name(){
                    return this._name;
                }
                set name(value){
                    Validator.validateString(value,2,40);
                    this._name=value;
                }


                get description(){
                    return this._description;
                }
                set description(value){
                    if(!value){
                        throw new Error('Description must not be empty or null!');
                    }

                    this._description = value;
                }
            }

            return Item;
        }());

        Book = (function(){
            class Book extends Item {
                constructor(name,description,isbn,genre){
                    super(name,description);

                    this.isbn = isbn;
                    this.genre = genre;
                }

                get isbn(){
                    return this._isbn;
                }
                set isbn(value){
                    Validator.validateIsbn(value);
                    this._isbn = value;
                }

                get genre(){
                    return this._genre;
                }

                set genre(value){
                    Validator.validateString(value,2,20);
                    this._genre = value;
                }
            }

            return Book;
        }());


        Media = (function(){
            class Media extends Item {
                constructor(name,description,duration,rating){
                    super(name,description);
                    this.duration = duration;
                    this.rating = rating;
                }

                get duration(){
                    return this._duration;
                }
                set duration(value){
                    Validator.validateNumberGreaterThanZero(value);
                    this._duration = value;
                }

                get rating(){
                    return this._rating;
                }
                set rating(rating) {
                        if(typeof rating !== 'number') {
                            throw 'Rating should be a number';
                        }
                        if(rating < 1 || rating > 5) {
                            throw 'Rating must be a number between 1 and 5';
                        }

                        this._rating = rating;
                    }
                }

            return Media;
        }());

        Catalog = (function(){
            var uniqueId = 0;
            class Catalog{
                constructor(name){
                    this._id = (uniqueId+=1);
                    this.name = name;
                    this.items = [];
                }
                get id(){
                    return this._id;
                }

                get name(){
                    return this._name;
                }
                set name(value){
                    Validator.validateString(value,2,40);
                    this._name = value;
                }

                add(...items){
                    if(!arguments || arguments.length === 0){
                        throw new Error("Invalid args in add method of catalog");
                    }

                    var arr = [];
                    if(Array.isArray(arguments[0])){
                        arr = items[0];
                    }else {
                        arr = Array.from(items);
                    }
                    if(arr.length === 0){
                        throw new Error('Add no arguments are passed');
                    }

                    for(let item of arr){
                        Validator.validateIfItIsItem(item);
                    }

                    for(let item of arr){
                        this.items.push(item);
                    }

                    return this;
                }

                find(args){
                    if(typeof args === "undefined" || args === "null"){
                        throw new Error('find no arguments');
                    }
                    if(typeof args === "number"){
                        for(let item of this.items){
                            if(item.id===args){

                                return item;

                            }
                        }

                        return null;
                    }

                    if(typeof args === "object" && args!== null){
                        return this.items.filter(function(item) {
                            return Object.keys(args).every(function(prop) {
                                return args[prop] === item[prop];
                            });
                        });
                    }

                    throw "Error find";
                }

                search(pattern){
                    if(pattern.length<1){
                        throw new Error('Short pattern in search method.');
                    }
                    pattern = pattern.toLowerCase();
                    var result = [];
                    for(var item of this.items){
                        if(item.name.toLowerCase().indexOf(pattern)>=0 || item.description.toLowerCase().indexOf(pattern)>=0){
                            result.push(item);
                        }
                    }

                    return result;
                }

            }
            return Catalog;
        }());

        BookCatalog = (function(){
            class BookCatalog extends Catalog {
                constructor(name){
                    super(name);
                }

                add(...books){
                    if(Array.isArray(books[0])){
                        books = books[0];
                    }

                    books.forEach(function(book){
                        if(!(book instanceof Book)){
                            throw new Error('not a book');
                        }
                    });

                    return super.add(...books);
                }

                getGenres() {
                    let uniq = {};
                    this.items.forEach(x=>uniq[x.genre] = true);
                    return Object.keys(uniq);
                }
                
                find(options){
                    return super.find(options);
                }
            }

            return BookCatalog;
        }());

        MediaCatalog = (function(){
            class MediaCatalog extends Catalog {
                constructor(name){
                    super(name);
                }

                add(...medias){
                    if(Array.isArray(medias[0])){
                        medias = medias[0];
                    }

                    medias.forEach(function(media){
                        if(!(media instanceof Media)){
                            throw new Error('not a media');
                        }
                    });

                    return super.add(...medias);
                }



                getTop(count){
                    if(!(typeof count === "number") || count < 1){
                        throw new Error('Invalid count');
                    }

                    return this.items.sort((a,b) => a.rating < b.rating).filter((_,y) => y < count).map(x=>({id:x.id , name: x.name}))
                }

                getSortedByDuration(){
                    return this.items.sort((a,b) => a.duration > b.duration).sort((c,d) => c.id < d.id);
                }

                find(options){
                    return super.find(options);
                }
                

            }

            return MediaCatalog;
        }());

        return {
            getBook: function (name, isbn, genre, description) {
                return new Book(name,description,isbn,genre);
            },
            getMedia: function (name, rating, duration, description) {
                return new Media(name,description,duration,rating);
            },
            getBookCatalog: function (name) {
                return new BookCatalog(name);
            },
            getMediaCatalog: function (name) {
                return new MediaCatalog(name);
            }
        }
  };

module.exports = solve;