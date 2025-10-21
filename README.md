# 🧪 Demo Webshop Automation using Selenium C# with NUnit & SpecFlow/ReqnFlow

## 📘 Project Overview
This project **Demo Webshop Automation** is an end-to-end UI automation framework built using **Selenium WebDriver**, **C#**, **NUnit**, and **SpecFlow** (or ReqnFlow).  
The main purpose of this project is to automate test cases in an efficient and reusable way using common page methods and modular test design principles.

URL - https://demowebshop.tricentis.com/
---

## 🧰 Tech Stack
- **Language:** C#  
- **Frameworks:** Selenium WebDriver, NUnit, SpecFlow / ReqnFlow  
- **Design Pattern:** Page Object Model (POM)  
- **Reporting:** Extent Reports  
- **Utilities:** Screenshot Helper, Property Reader, Extent Report Manager  

---
## 🧑‍💻 Author
**Sourav Naga** 

---
## 📦 NuGet Packages Used

This project uses the following NuGet packages to support Selenium automation, reporting, and BDD-style testing:

| Package Name                              | Version        | Description                                                                 |
|-------------------------------------------|----------------|------------------------------------------------------------------------------|
| **DotNetSeleniumExtras.PageObjects**      | 3.11.0         | PageObjects pattern implementation for .NET                                 |
| **DotNetSeleniumExtras.PageObjects.Core** | 3.11.0         | Core PageObjects support for .NET                                           |
| **DotNetSeleniumExtras.WaitHelpers**      | 3.11.0         | ExpectedConditions for WebDriverWait in .NET                                |
| **ExtentReports**                         | 4.1.0          | Reporting library for test automation                                       |
| **ExtentReports (TeamCity Edition)**      | 4.1.0          | TeamCity-compatible version of ExtentReports                                |
| **Microsoft.NET.Test.Sdk**                | 17.4.1         | MSBuild targets for building .NET test projects                             |
| **NUnit**                                 | 3.13.3         | Unit-testing framework for .NET                                             |
| **NUnit3TestAdapter**                     | 4.5.0          | Adapter for running NUnit tests in Visual Studio                            |
| **Reqnroll.NUnit**                        | 2.2.1          | Reqnroll integration with NUnit (BDD-style testing)                         |
| **Selenium.Community.PageObjects**        | 1.0.0          | PageObject implementation for Selenium WebDriver                            |
| **Selenium.Firefox.WebDriver**            | 0.27.0         | Firefox (Marionette) WebDriver for Selenium                                 |
| **Selenium.WebDriver.ChromeDriver**       | 141.0.3790.0   | ChromeDriver for Selenium WebDriver                                         |
| **Selenium.WebDriver.GeckoDriver**        | 0.33.0         | GeckoDriver for Firefox automation                                          |
| **Selenium.WebDriver.IEDriver**           | 4.0.0.0        | Internet Explorer Driver for Selenium WebDriver                             |
| **Selenium.WebDriver.MSEdgeDriver**       | 141.0.3537.71  | Edge (Chromium) WebDriver for Selenium                                      |
| **System.IO**                             | *(Microsoft)*  | Base I/O types for reading/writing streams                                  |
| **System.IO.FileSystem.Primitives**       | *(Microsoft)*  | Common enums and exceptions for path-based I/O                              |

---


## 📂 Project Structure
```
DemoWebshopAutomation/
│
├── Features/                   # Contains feature files (Gherkin syntax)
│   ├── Login.feature
│   ├── Register.feature
│   ├── ProductSearch.feature
│   ├── OrderDetails.feature
│   └── SuccessOrder.feature
│
├── Pages/                      # Page classes following POM structure
│   ├── CommonPageMethods.cs    # Common reusable methods (click, wait, enter text, etc.)
│   ├── LoginPage.cs
│   ├── RegisterPage.cs
│   ├── ProductSearchPage.cs
│   ├── OrderDetailsPage.cs
│   └── SuccessOrderPage.cs
│
├── Hooks/                      # SpecFlow binding and hooks classes
│   └── HooksClass.cs           # Includes [BeforeScenario], [AfterScenario], etc.
│
├── TestData/
│   └── data.properties         # Key-value pair test data
│
├── Reports/                    # Stores generated Extent HTML reports
│
├── Screenshots/                # Captures screenshots on test failure
│
├── Utilities/
│   ├── ExtentReportManager.cs
│   ├── ExtentTestManager.cs
│   ├── PropertiesReader.cs
│   └── ScreenshotHelper.cs
│
├── AssemblyInfo.cs             # Assembly information for parallel test execution
│
└── DemoWebshopAutomation.csproj
```

---

## 🧱 Project Design Flow

1. **Feature File Design**  
   - Each feature file describes a specific user flow using Gherkin syntax (`Feature`, `Scenario`, `Given`, `When`, `Then`).
   - Example: Login, Register, Product Search, Order Details, and Order Success.

2. **Page Object Model Implementation**  
   - Each page (LoginPage, RegisterPage, etc.) has:
     - Constructor using `PageFactory.InitElements(driver, this)`
     - `FindsBy` annotations for identifying elements.
     - Methods performing specific user actions.

3. **Common Page Methods**  
   - Inside `CommonPageMethods.cs`, reusable utility methods are implemented:
     - `HighlightElement()`
     - `WaitForVisible()`
     - `IsElementPresent()`
     - `Click()`
     - `EnterText()`
     - etc.

4. **Hooks Implementation**  
   - `HooksClass.cs` includes `[BeforeScenario]` and `[AfterScenario]` for pre/post actions like:
     - Opening browser
     - Initializing driver
     - Capturing screenshots on failure
     - Closing browser sessions

5. **Reports & Logs**  
   - Extent Reports generate HTML reports after each test run.
   - Screenshots are automatically saved for failed steps.

6. **Utilities Layer**  
   - Common helper classes are maintained under `Utilities`:
     - `ExtentReportManager.cs`
     - `ExtentTestManager.cs`
     - `PropertiesReader.cs`
     - `ScreenshotHelper.cs`

---

## ⚙️ How to Run the Project

### 1️⃣ Clone the Repository
```bash
git clone https://github.com/SouravNaga/E-commerce-Website-Automation-Using-SeleniumCSharp-ReqnFlow-NUnit.git
cd DemoWebshopAutomation
```

### 2️⃣ Open in Visual Studio
- Open the `.sln` file in Visual Studio.
- Restore NuGet packages if prompted.

### 3️⃣ Build the Project
Go to:
```
Build → Build Solution (Ctrl + Shift + B)
```

### 4️⃣ Run the Tests
You can run tests via:
- **Visual Studio Test Explorer**, or  
- **Command Line:**
```bash
dotnet test
```

---

## 📊 Test Execution Reports
- After execution, HTML reports are generated in the `/Reports` folder.
- Screenshots of failed tests are stored in `/Screenshots`.


  

---

## 🚀 Future Improvements
- Integrate CI/CD pipeline (GitHub Actions or Jenkins)  
- Add parallel cross-browser execution (Chrome, Edge, Firefox)  
- Integrate Dockerized Selenium Grid  

---

## 🖼️ Screenshots


---


## 🧑‍💻 Important Code snippets

AssenmblyInfo.cs
----------------

           
            [assembly: Parallelizable(ParallelScope.Children)]
            [assembly: LevelOfParallelism(4)]


Hooks.cs
---------
            string folderPath = Path.Combine(Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName, "TestData\\");
            var config = PropertiesReader.LoadProperties(folderPath + "data.properties");
            string browser = config["browser"];

RegisterSteps.cs
-------------------

            var dict = dataTable.Rows.ToDictionary(row => row["Field"], row => row["Value"]);
            Console.WriteLine($"Gender: {dict["Gender"]}");
            Console.WriteLine($"Firstname: {dict["Firstname"]}");
            Console.WriteLine($"Lastname: {dict["Lastname"]}");
            //Console.WriteLine($"Email: {dict["Email"]}");
            registerpage.selectGender(dict["Gender"]);
            registerpage.enterFirstName(dict["Firstname"]);
            registerpage.enterLastName(dict["Lastname"]);
            registerpage.enterEmail(config["Email"]);

Feature file
------------
Feature: Verify Register feature

Background: 
	Given Open the browser
	When Login the url
@register
Scenario: Register feature with valid creds
	Given Click on the Register button
	When Fill all details with valid data
	| Field     | Value         |
    | Gender      | male        |
    | Firstname       | sourav            |
    | Lastname   | naga         |


**⭐ Don’t forget to star this repository if you find it useful!**
