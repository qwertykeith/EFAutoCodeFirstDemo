# example of doing awesome automatic EF code first

i probably should write a blog to explain this but haven't really got the time .. just look around.. it's pretty cool and should be understandable from the code.. then google stuff

change something in one of the models in the data project and run it again... see the magic

### basic instructions to run locally

change the connection string in the webconfig to one you can use (don't change the name SomeDBContext)

p.s. yea yea.. no repository pattern here... it's just a demo of EF cod first awesomeness... still have to architecture it nicely

### from scratch

* create a database
* optionally add a project with an entity data model
* run `enable-migrations -EnableAutomaticMigrations` in the package manager on the db project
* add the initialiser to the startup in global.asx (maybe keep the code in the db project and call it from global.asax)
* _(or for manual updates do `Update-Database` every time)_

```
Database.SetInitializer(new MigrateDatabaseToLatestVersion<SomeDBContext, Configuration>()); 
```

### Links

* https://msdn.microsoft.com/en-us/library/dn579398(v=vs.113).aspx
* this tries to talk you out of it.. don't listen to microsoft ... https://msdn.microsoft.com/en-us/library/dn481501(v=vs.113).aspx

* for mocking http://www.vannevel.net/2015/02/26/11/