# example of doing awesome automatic EF code first

i probably should write a blog to explain this but haven't really got the time .. just look around.. it's pretty cool and should be understandable from the code.. then google stuff

change something in one of the models in the data project and run it again... see the magic

### basic instructions to run locally

change the connection string in the webconfig to one you can use (don't change the name SomeDBContext)

p.s. yea yea.. no repository pattern here... it's just a demo of EF cod first awesomeness... still have to architecture it nicely

### from scratch

* create a database
* optionally add a project with an entity data model
* run `Enable-Migrations` in the package mamnager on the db project
* change `AutomaticMigrationsEnabled = true` 
* add the initialiser to the startup in global.asx (maybe keep the code in the db project and call it from global.asax)

```
Database.SetInitializer(new MigrateDatabaseToLatestVersion<SomeDBContext, Configuration>()); 
```