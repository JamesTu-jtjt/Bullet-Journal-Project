# Bullet Journal Application

## Overview
This is a bullet journal application implemented in C# and SQL. It provides users with the ability to create accounts, log in, and start managing their own bullet journal. The application features multiple forms and functionalities to help users organize their tasks and goals effectively.

## Execution Environment
- Visual Studio

## Programming Language
- C#
- SQL

## Features

### User Account Management
- The application starts with a simple account and password user interface for account creation.
- User accounts are saved to the database.
- Users can log in using their account credentials.

### Bullet Journal
- After successfully logging in, users can access their own bullet journal.
- The application features a menu strip in the top left corner with various actions.

### Account Information
- Users can change their account information, but account names cannot be modified.

### User Guide
- The application provides a guide on how to use the bullet journal effectively.

### Logs
- Users can maintain logs for yearly, monthly, and daily goals.
- The log menu strip has options for adding and deleting data from the bullet journal.
- Data can be refreshed to see the updated results.

### Data Relations
- Logs are organized by year, month, and date.
- The application allows users to relate yearly, monthly, and daily logs.

### Project Management
- Users can manage their projects and set time intervals.
- Logs related to a project cannot be outside the project's bounds.

### Chart Generation
- Users can create charts for their projects.

## Database
The application uses the following data tables:

1. `Acc_pass`: Stores user account information, including name, birthday, and password.
2. `person_index`: Stores user account information and filenames of user-specific databases.
3. `Yearly`: Stores yearly goals with fields like ID, Year, Log_Name, Description, and tags.
4. `Monthly`: Stores monthly goals with fields like ID, Year, Month, Log_Name, Description, and tags.
5. `Daily Logs`: Stores daily goals with fields like ID, Year, Month, Date, Log_Name, Description, and tags.
6. `Proj_list`: Contains distinct values of all projects in the journal.
7. `Proj_data`: Stores project start and end times, along with other descriptions.

## Notes
- Tags in the application represent project labels.
- Data tables for each user are generated individually at runtime.
- The application is in English; Chinese characters are not supported.
- To see results, refresh the application after each addition or deletion.

## PowerPoint Presentation
For more information, refer to the [PowerPoint presentation](https://docs.google.com/presentation/d/1SjUedWt_Lq0WEQEdnyi-LjLh14boA4wF1XDPX5daW90/edit?usp=sharing) for a visual overview of the application.
