# Microservices Asynchronous Communication with RabbitMQ and MassTransit

<img src="https://www.yogihosting.com/wp-content/uploads/2026/10/Microservices-Asynchronous-Communication-with-RabbitMQ-and-MassTransit.png" alt="Microservice Asynchronous Communication with RabbitMQ and MassTransit"  title="Microservice Asynchronous Communication with RabbitMQ and MassTransit">

Here we will understand how Asynchronous Communication between Microservices work. In our Pizza Drone Delivery application we have 2 Microservices – CommandCenter and ProcessCenter. They communicate with one another synchronously using HttpClient class.

**Repository is updated to .NET 10.0**

Read the entire article here - https://www.yogihosting.com/aspnet-core-microservice-asynchronous-communication-rabbitmq-masstransit/

# Tutorial Contents
1. What is RabbitMQ
2. Setting Publisher microservice in RabbitMQ
3. What is MassTransit
4. Setting Consumer microservice in RabbitMQ
5. Storing the PizzaItems Collection in MongoDB for ProcessCenter Microservice
6. Installing RabbitMQ with Docker
7. Testing the Microservices

# How to run the app

Run both the Microservices one by one by the docker compose commands:

```
docker-compose build
docker-compose up -d
```

<img src="https://www.yogihosting.com/wp-content/uploads/2026/10/docker-compose-up.png" alt="Docker Compose Up Command" title="Docker Compose Up Command" class="img-fluid">

Now access the CCUI project on the browser. It’s url being – `https://localhost:9001/`

<img src="https://www.yogihosting.com/wp-content/uploads/2026/10/create-order-ccui.png" alt="Create Order CCUI" title="Create Order CCUI" class="img-fluid">

Also access the Web API with Swagger. It's url being - `https://localhost:8001/swagger`

<img src="https://www.yogihosting.com/wp-content/uploads/2026/10/swagger.png" alt="Swagger" title="Swagger" class="img-fluid">

Access the PCUI project on the browser. It’s url being – `https://localhost:7001/`

<img src="https://www.yogihosting.com/wp-content/uploads/2026/10/processcenter-microservice-add-record.png" alt="ProcessCenter Microservice Add Record"  title="ProcessCenter Microservice Add Record">

Also access the Web API with Swagger. It's url being - https://localhost:6001/swagger

<img src="https://www.yogihosting.com/wp-content/uploads/2026/10/swagger-processcenter.png" alt="ProcessCenter Swagger"  title="ProcessCenter Swagger">

## Want to support me ?

Your support of every $5 will be a great reward for me to carry on my work. Thank you!

<a href="https://www.buymeacoffee.com/YogYogi" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" alt="Buy Me A Coffee" width="200"  style="height: 60px !important;width: 200px !important;" ></a>
<a href="https://www.paypal.com/paypalme/yogihosting" target="_blank"><img src="https://raw.githubusercontent.com/yogyogi/yogyogi/main/paypal.png" alt="Paypal Me" width="300"></a>

