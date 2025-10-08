## About User data Validation

Following Steps have been used to develop this solution

### Scope : To create a program/DLL to validate user input

**Step 1: Create a user data valiadtion logic to check Email ID and Phone number.**
- Code has been written using SOLID principles
- Dependency Injection has been added
- Unit testing can be added later

### Local Testing
#### Positive Testing

<img width="1598" height="967" alt="image" src="https://github.com/user-attachments/assets/8caf7877-874c-4ecb-8cab-9ad7b0f81cb8" />


### Negative Testing
When email ID is incorrect

<img width="1548" height="917" alt="image" src="https://github.com/user-attachments/assets/632ac12d-0484-4941-be93-d916b8de3759" />

<div>
  <br/>
</div>

**Step 2: Create a Logic App that can call this function and execute logic.**
#### Logic app cannot directly call a DLL, hence workaround is to call a HTTP triggered Function App that can respond with Validation Message


