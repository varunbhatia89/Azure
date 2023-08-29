DotNet Core + 		XUnit/NUnit = Deployment Strategy = Azure
			Devops (CI)
			Azure (CD)

1. What is Azure Devops?
2. What are the steps of XUnit in .Net Core?
3. What is PipeLine (CI & CD)?
4. Application Architecture

11/08/2023
------------------------------------------------

What is the architecture of the Application?

	----Core with API Solution
	----Unit Test Solution
	----Github Account (Repository is created)
	----Devops (Continuous Integration of Repository)
	----Azure (With Devops with Github Repository with Application ---to achieve Continuous Deployment)


	Github Repository ---------  https://github.com/varunbhatia89/Azure.git

	16-08-2023
	---------------------------------------------------------------------

	Devops has so many features
		1. Pipeline (Unit Testing, Integration) - Pipeline is a delegation model of Devops to notify to any repository to achieve callback


21-08-2023
-----------------------------------------------------------------------
Now we need to see whether application supports CI or not?


26-08-2023
------------------------------------------------------------------
git add .
git status
git commit -m "Initial Commit"
git status
git push origin main


https://dotnetplaybook.com/build-test-and-deploy-a-rest-api-with-azure-devops/

29-08-2023
---------------------------------------------------------
Continuous Integration is running successfully with Unit Test.

---> Azure artifacts (packaging)

Publish + Zip 