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
Local azurite emulator not working properly, (since Personal use laptop with Home edition have various OS, setup, network and other restrictions) hence unable to run "Designer" on local.

**Hence had to do development in Azure Portal**

<img width="1479" height="929" alt="{371C7812-74C7-47D4-A89E-2BE07B29BD32}" src="https://github.com/user-attachments/assets/97102fa9-4b78-4cf5-99cf-6e7269d9ef7c" />

<div>
  <br/>
</div>

### Step 2: Deploy .NET code that validates user data into Azure Function App

**2a: Deployment**

<img width="975" height="518" alt="image" src="https://github.com/user-attachments/assets/46e08fd5-7ec6-4eee-babf-db6cea6d6725" />

**2b:  Azure Function App**

**URL:** hcafuncapp1-cbhteydqepc5bvgc.canadacentral-01.azurewebsites.net

<img width="1887" height="808" alt="{8A498BE1-C4F9-4D04-AEC9-5E91ECE730E0}" src="https://github.com/user-attachments/assets/6db8952b-a58d-4582-a070-0fbd4bac0b1e" />

<br/>

**2c:  Grab App keys**

<img width="1911" height="758" alt="{D7AFD02F-D349-45E8-89AA-9A4A13583797}" src="https://github.com/user-attachments/assets/86fd26f4-05bb-453b-9f32-8dc357314ee0" />
<br/>

**2d: Test deployed Azure function app, via Postman**

#### Negative testing
<img width="1405" height="886" alt="{8C4C55C1-99E0-4005-9A2E-0D518E222F4C}" src="https://github.com/user-attachments/assets/1739357e-450f-46fb-8343-be68bf49b85e" />

### Step 3:  Create a Logic App, that call Azure function via API call

**3a: create a Logic App**
<img width="1879" height="796" alt="{1B4B4F11-E3E2-45E9-A42F-78CC5CF9D0A2}" src="https://github.com/user-attachments/assets/b526a451-7df7-41be-83cf-cf18b0d5b26f" />

<br/>

**3b : Create Workflow**

*create a Trigger, that gets invoked via HTTP call, define Payload schema*
<img width="1590" height="801" alt="{C2F25A00-4D67-490C-B37B-778E1C7BCBE8}" src="https://github.com/user-attachments/assets/38979b82-288c-440b-849a-f87c48466c2b" />
<br/>

*Create an **Action** to call Data validator Azure function*

**Azure managed Identity has been choosen, for easy access**

This action will call Azure function app, and send incoming payload
<img width="1507" height="515" alt="{88278F61-C74F-4FCD-A50F-17B9233216F1}" src="https://github.com/user-attachments/assets/3aa98c8c-b087-49ce-980a-6e6ebe872e9a" />
<br/>

*Create a HTTP response, to return data from Azure function App*
<img width="1337" height="533" alt="{9A3D8A7B-4A9D-430C-AC51-F8B37275F45F}" src="https://github.com/user-attachments/assets/4c5162dd-8246-45b5-9f44-f107daeebd0c" />

<br/>


**3c: Testing Logic App**

*Grab HTTP URL for logic app*


<img width="1485" height="423" alt="{3531258E-CE9E-425B-B32F-D903D2B6B372}" src="https://github.com/user-attachments/assets/30933cd5-515b-4b88-8271-2c855d6ad130" />



*Test via Postman*

<img width="1310" height="834" alt="{CA32DCF8-BE52-4917-B7F5-829C5AA6399B}" src="https://github.com/user-attachments/assets/5a552271-4b97-4ce1-a08f-5d9c32394c23" />



