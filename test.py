print("hello world!")

def main():
    david = Person("David", 24, "male")
    print(david.gender)


class Person:
    def __init__(self, name: str, age: int, gender: str):
        self.name = name
        self.age = age
        self.gender = gender


main()
