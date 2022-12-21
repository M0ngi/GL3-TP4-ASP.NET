# TP4 ASP.NET

## Description

A simple application of Repository design pattern to fetch Model data from a database (SQLite) & using Singleton design pattern for database context/connection.

Database file is saved within the project's files under the name `tp4.db`

Bootstrap used for styling.

## Routes

The web app provides the following routes:
* `/Home`: Default
* `/Student`: Shows the full list of students (Id, first & last name, phone number, course, university)
* `/Student/Courses`: Shows a list of unique courses studied by students.
* `/Course/{course name}`: Shows the list of students whom are following the given course.

## Requirements

* .NET 6.0
