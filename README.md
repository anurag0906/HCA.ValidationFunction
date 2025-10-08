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


### Please Note
Local azurite emulator not working properly, (due to personla use Laptop and OS restrictions) hence unable to run "Designer" on local. **Hence had to do development in Azure Portal**
<img width="1479" height="929" alt="{371C7812-74C7-47D4-A89E-2BE07B29BD32}" src="https://github.com/user-attachments/assets/97102fa9-4b78-4cf5-99cf-6e7269d9ef7c" />

<div>
  <br/>
</div>

### Step 2: Deploy .NET code that validates user data into Azure Function App

**2a: Deployment**

<img width="975" height="518" alt="image" src="https://github.com/user-attachments/assets/46e08fd5-7ec6-4eee-babf-db6cea6d6725" />

**2b:Azure Function App**
**URL:** hcafuncapp1-cbhteydqepc5bvgc.canadacentral-01.azurewebsites.net
<img width="1887" height="808" alt="{8A498BE1-C4F9-4D04-AEC9-5E91ECE730E0}" src="https://github.com/user-attachments/assets/6db8952b-a58d-4582-a070-0fbd4bac0b1e" />

**2c:Grab App keys**
<img width="1911" height="758" alt="{D7AFD02F-D349-45E8-89AA-9A4A13583797}" src="https://github.com/user-attachments/assets/86fd26f4-05bb-453b-9f32-8dc357314ee0" />

