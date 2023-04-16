Bullet Journal Application

Execution Environment: Visual Studios
Programming Language: C#, SQL. 
This UI provides the service of allowing users to create accounts, log in, and start making their own bullet journal. 
There is a menu on the top left which allows the user to execute different actions. 


Program Review:
The first form that is created when the program is run is a simple Account and Password user interface that allows you to create your own account (second form for account creation) and saves it to the database. 
Once you have created your account and see a success message, you can use your Account and Password to log in to your own bullet journal, which will be the third form. 
Once you enter, there is a menu strip on the top left corner of the application. It provides functions such as changing your account information. 
(Please be reminded that Account name IS NOT ALLOWED TO BE MODIFIED. 
Other than that, there is also a guide that will teach you how to use the bullet journal. 
Next on, we move into the logs of your bullet journal. 
The Log menu strip has three rows in the ui that represent Yearly, Monthly and Daily Logs of our bullet journal respectively. 
The blue and red buttons allow you to add and delete data from your bullet journal, and you can refresh the application to see the updated result. 
The Log menu strip also has a relation option where we have helped you relate the three datagridviews together. 
Yearly and Monthly Logs are linked by Year, and Monthly and Daily logs are linked by Month. 
The Project menu strip allows you to see your logs by project tags as well as a list of your projects. 
Once you set the time interval of the project, all logs of the project cannot be out of bounds of the project. 
You can also draw charts of your projects.

Database: 
DataTables: 7
Acc_pass => A data table that stores the user account, name, birthday, as well as password.
person_index=> Stores the user's account as well as the filenames of the databases created for the use. 
Yearly => Goals you have to achieve in a year. Saves the ID, Year, Log_Name, Description, and tags.
Monthly=> Goals you have to achieve in a month. Saves the ID, Year, month, Log_Name, Description, and tag.
Daily Logs Goals you have to achieve in a day. Saves the ID, Year, month, date, Log_Name, Description, and tag.
Proj_list=> A list of all the distinct valus of all the projects in the journal. 
Proj_data=> A list of data that stores your project's start and end time, as well as other discriptions. 



Notes: 
The tags in the function are the labels of projects of the user. 
DataTables for every person are generated individually during runtime. 
This is an English Version of the application, DO NOT LOG CHINESE!!!
To see result, refresh after each addition or deletion. 

Powerpoint Link: 
https://docs.google.com/presentation/d/1SjUedWt_Lq0WEQEdnyi-LjLh14boA4wF1XDPX5daW90/edit?usp=sharing