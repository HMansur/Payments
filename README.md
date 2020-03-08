# Payments

Description: The project retrieves portfolio payments details from json emitted by the BNP interview portal :
https://focus.interview/api/v1.0/payments/{portfolioId}

This was written on VS2017 in 32 bit windows 10 platform as a Console Application.

Requires Newtonsoft.Json nuget package

Interviewer is requested to change the path variable to suit his/her requirements to enable CSV file generation in variable in Program.cs called 'path'.

Interview: Please note that the URL specified returns errors with notice "Make sure that you’ve got the right web address: "https://focus.interview". Also I could not use jsonviewers such as "jsonviewer.stack.hu" as they do not accept https protocol.

Even though I could not run the project with actual json I modelled the data using the sample provided in the interview question and believe with the time limit of 1 hr - I wrote a solution that should work. If there was more time allowed and the downloads were large, I probably would have looked into Tasks and asych/await structures to enable parallel processing.

Hope this helps.


