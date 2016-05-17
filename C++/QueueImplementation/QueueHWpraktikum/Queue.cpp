#include<iostream>
using namespace std;
template <typename T>
struct Node {
	T data;
	Node *next;
	Node(T _data, Node *_next = nullptr) :
		data(_data), next(_next) {}
};

template <typename T>
class Queue {
	Node<T> *front;
	Node<T> *rear;
	int size;

	void clear() {
		while (!isEmpty()) {
			Dequeue();
		}
	}

	void copy(const Queue& other) {
		size = other.size;
		if (other.front == nullptr) {
			front = nullptr;
			rear = nullptr;
		}
		else {
			Node<T> *currOther = other.rear;
			Node<T> *curr = new Node<T>(currOther->data);
			rear = curr;

			currOther = currOther->next;
			while (currOther != nullptr) {
				curr->next = new Node<T>(currOther->data);
				curr = curr->next;
				currOther = currOther->next;
				if (currOther = nullptr)
					front = curr;
			}

		}
	}

public:

	Queue() {
		front = nullptr;
		rear = nullptr;
		size = 0;
	}

	Queue(const Queue& other) {
		copy(other);
	}

	Queue& operator=(const Queue& other) {
		if (this != &other) {
			clear();
			copy(other);
		}

		return *this;
	}

	~Queue() {
		clear();
	}

	int getSize() const {
		return size;
	}

	bool isEmpty() const {
		return front == nullptr;
	}

	T getFront() const {
		return front->data;
	}

	void Enqueue(const T element) {
		Node<T> *temp = new Node<T>(element, nullptr);
		if (isEmpty())
		{
			front = temp;
			rear = temp;
		}
		else
		{
			rear->next = temp;
			rear = temp;
		}
		size++;
	}

	void Dequeue() {

		Node<T> *temp = front;
		size--;
		if (size >= 1) {
			front = front->next;
		}
		if (isEmpty())
		{
			front = nullptr;
			rear = nullptr;
		}
		delete temp;

	}

	void print() {
		Node<T> *curr = front;
		while (curr != nullptr) {
			cout << curr->data << " ";
			curr = curr->next;
		}
		cout << endl;
	}

	void MergeQueues(Queue &other)
	{
		Node<T> *curr = other.front;
		while (curr != nullptr)
		{
			Node<T> *node = new Node<T>(curr->data, nullptr);
			rear->next = node;
			rear = node;
			curr = curr->next;
		}
		size += other.size;
	}
};
int main()
{
	Queue<int> queue;
	queue.Enqueue(100);
	cout << queue.getFront() << endl;
	queue.Enqueue(200);
	queue.Enqueue(300);
	queue.Enqueue(400);
	queue.print();
	cout << queue.getFront() << endl;
	queue.Dequeue();
	queue.print();
	Queue<int> queue2;
	queue2.Enqueue(2);
	queue2.Enqueue(3);
	queue.MergeQueues(queue2);
	queue.print();
	system("pause");
	return 0;
}