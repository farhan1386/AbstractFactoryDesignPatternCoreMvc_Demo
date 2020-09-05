# Abstract Factory Design Pattern with ASP.Net Core MVC 3.1

# What is Abstract Factory Design Pattern?

Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes. Abstract factory is a super factory that creates other factories

# When Choose Abstract Factory Pattern?

1.	The application need to create multiple families of objects or products
2.	We need to use only one of the subset of families of objects at a given point of time
3.	We want to hide the implementations of the families of products by decoupling the implementation of each of these operations

# Business Requirement: Handout computers to Contract and Permanent employees based on the designation and employee type with below specifications

Permanent Employee

•	Managerial Position is eligible for Apple MAC Book Laptop
•	Non Managerial Position is eligible for Apple IMac desktop
Contract Employee

•	Managerial Position is eligible for Dell Laptop
•	Non Managerial Position is eligible for Dell desktop

# The illustrated diagram of Abstract Factory Representation 

1.	Client is a class which use AbstractFactory and AbstractProduct interfaces to create a family of related objects.
2.	AbstractFactory is an interface which is used to create abstract product.
3.	ConcreteFactory is a class which implements the AbstractFactory interface to create concrete products.
4.	AbstractProduct is an interface which declares a type of product.
5.	ConcreteProduct is a class which implements the AbstractProduct interface to create product.

