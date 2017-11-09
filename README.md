# Project1

Create an MVC website that will allow future missionaries to ask questions of past missionaries.
On the landing page I want you to implement a bootstrap jumbotron class to create a “call to action” which for now will not have any functionality (If you don’t know what a call to action is, google it!). The landing page (home page), should also display any content that is conducive to missionary work (i.e. quotes, videos, etc. – be creative)
Your website should be harmonious with missionary work throughout the world (you can be creative)
On the landing page there will be three main links:
Missions – should take you to the missions view
The missions view will have a dropdown that will consist of (for now) three missions (you will choose any 3 missions which have been hardcoded into the dropdown).
As the user clicks on an entry in the mission list, take them to another view (_____ mission FAQ’s) which is dynamically loaded using source code. For now, the questions and answers on the view for each mission will all be the same (HARD CODED - You will create the question and answer), regardless of which mission is chosen. You must however pass the following unique information for each mission in the viewbag:
 
<ul>
<li>mission name</li>
<li>mission president’s name</li>
<li>mission address</li>
<li>language</li>
<li>climate</li>
<li>dominate religion</li>
<li>a flag or symbol for the mission.</li>
</ul>
 

You will need to display all of this information in a section above the FAQ’s on the dynamically loaded view. Please make it look professional. Talk with classmates and talk about the most effective ways to display this information.
At the top of the each dynamically created view, you will display a bootstrap breadcrumb (Google it!) that will help the user better navigate your site. Using this breadcrumb menu, the user should be able to go back to the missions page to select a different mission.
At the very bottom of each dynamically created mission’s FAQ’s will be a question form. The user will be able to fill out this form to post a new question, just like you would post a comment on Facebook. ** For project 1 we will not be posting the questions or saving them in the database, we just want the form to be there and available.
Under each FAQ question, there will also need to be a way for a user to answer that specific question, so you will need to add a reply button in order to have a response form dynamically created when a missionary wants to answer another missionary’s question. You do not need to save the replies for this project.
 

About us- should take you to the about view

The About view should display “made up” information about the company that wants to help future missionaries get questions about their missions answered by those that have been to the mission.
 

Contact – should take you to the contact view

The contact view will have basic company information, such as phone number and email. The view will also have a contact form that will have fields for the user’s name, email, subject(choose from a list), and message body.
There will need to be a submit button at the bottom of the contact form. This button however, won’t do anything with the data yet. For now it will just clear the text in the form.
