# Setup
- Clone and build the project
- Configure connection string for DbMigrator in appsettings.json and run Dbmigrator. (PosgreSQL)
- Configure connection string and Dapr HTTP/GRPC Endpoints for Web in appsettings.json (PosgreSQL)
- Configure Dapr to use PubSub Component (Sample file is in "dapr-component-file" folder at root)
- Run dapr side-car (daprd -app-id dapr-event-bus-service -dapr-http-port 3500 -dapr-grpc-port 3600 --metrics-port 9090 --app-port 44391 --app-ssl --components-path {PATH_TO_DAPR_PUBSUB_COMPONENT_FILE}
- Run app using Kestrel Server rather than IIS-Express

# Issue occurs when
- Run Web Project and go to swagger UI from browser. (https://localhost:44391/swagger/index.html)
- Find "DaprEventBus" in swagger UI and execute first endpoint /api/app/dapr-event-bus/publish
- Check log file for error detail

#  Issue does not occur when
- Include DaprEventBusEventHandler.cs file inside "EventHandlers" under "Dapr.EventBus.Application" project
- Run web project and execute first endpoint /api/app/dapr-event-bus/publish under "DaprEventBus" from Swagger.

