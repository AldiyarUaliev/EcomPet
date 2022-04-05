My Pet Project (Just for Learning) is on progress. You just can see the structure and some design

- Catalog microservice which includes;
    ASP.NET Core Web API application
    REST API principles, CRUD operations
    MongoDB database connection and containerization
    Repository Pattern Implementation
    Swagger Open API implementation

- Basket microservice which includes;
    ASP.NET Web API application
    REST API principles, CRUD operations
    Redis database connection and containerization
    Publish BasketCheckout Queue with using MassTransit and RabbitMQ

- Microservices Communication
    Async Microservices Communication with RabbitMQ Message-Broker Service
    Using RabbitMQ Publish/Subscribe Topic Exchange Model
    Using MassTransit for abstraction over RabbitMQ Message-Broker system
    Publishing BasketCheckout event queue from Basket microservices and Subscribing this event from Ordering microservices
    Create RabbitMQ EventBus.Messages library and add references Microservices

- Ordering Microservice
    Implementing CQRS, and Clean Architecture with using Best Practices
    Developing CQRS with using MediatR, FluentValidation and AutoMapper packages
    Consuming RabbitMQ BasketCheckout event queue with using MassTransit-RabbitMQ Configuration
    SqlServer database connection and containerization
    Using Entity Framework Core ORM and auto migrate to SqlServer when application startup

- API Gateway Ocelot Microservice
    Implement API Gateways with Ocelot
    Sample microservices/containers to reroute through the API Gateways
