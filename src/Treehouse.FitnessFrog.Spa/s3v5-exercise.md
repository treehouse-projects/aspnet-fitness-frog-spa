
# Excercise: Adding the Activites and Intensities API Endpoints

## Activites API Endpoint

* Add an API controller named `ActivitesController`
* Add a controller action method to handle GET requests
  * The method should return a collection of resources representing the available activities
* Each returned activity resource should have an `id` and `name` property
* Use the `ActivitiesRepository.GetList` method to get a list of the available activities

## Intensities API Endpoint

* Add an API controller named `IntensitiesController`
* Add a controller action method to handle GET requests
  * The method should return a collection of resources representing the available intensities
* Each returned intensity resource should have an `id` and `name` property
* Use the .NET Framework `Enum.GetValues` static method to enumerate the values of the `Entry.IntensityLevel` enumeration
