[//]: # (# Survey Report Generation)

[//]: # ()
[//]: # (## Installation)

[//]: # (* Clone repository ini)

[//]: # (    ```bash)

[//]: # (    git clone https://github.com/alvinfebriando/questionnaire-dotnet )

[//]: # (    ```)

[//]: # (* Install .NET 6 dari link [ini]&#40;https://dotnet.microsoft.com/en-us/download&#41;)

[//]: # ()
[//]: # (## Usage)

[//]: # (* Melalui dotnet-cli )

[//]: # (    ```bash)

[//]: # (    dotnet run --project .\src\WebApi)

[//]: # (    ```)

[//]: # ()
[//]: # (## Endpoints)

[//]: # (Terdapat 2 endpoint yang bisa digunakan yaitu)

[//]: # (* `POST /api/survey` untuk mendapatkan laporan yang dihasilkan )

[//]: # (    ```bash)

[//]: # (    POST /api/survey HTTP/1.1)

[//]: # (    Host: localhost:7145)

[//]: # (    Content-Type: application/json)

[//]: # (    Content-Length: 292)

[//]: # (    )
[//]: # (    {)

[//]: # (      "place": "USU",)

[//]: # (      "date": "2020-01-01",)

[//]: # (      "subject": "Kepuasan pengajaran mata kuliah Kecerdasan Buatan",)

[//]: # (      "respondent": "50",)

[//]: # (      "lecturer": "pak Alvin",)

[//]: # (      "questionCount": 13,)

[//]: # (      "aspectCount": 6,)

[//]: # (      "answers": [4.1, 4.3, 1.7, 2.4, 3.8, 4.8, 1.62, 2.6, 3.62, 4.12, 3.84, 2.2, 1.4]    )

[//]: # (    })

[//]: # (    ```)

[//]: # (* `POST /api/simulator` untuk mendapatkan simulasi jawaban)

[//]: # (    ```bash)

[//]: # (    POST /api/simulator HTTP/1.1)

[//]: # (    Host: localhost:7145)

[//]: # (    Content-Type: application/json)

[//]: # (    Content-Length: 86)

[//]: # (    )
[//]: # (    {)

[//]: # (      "respondentCount": "50",)

[//]: # (      "dominantScores":  [4,1,2,5,4,1,3,1,2,5,4,1,3])

[//]: # (    })

[//]: # (    ```)

[//]: # ()
[//]: # (## Entry Point)

[//]: # (* `POST /api/survey`)

[//]: # (  * `src/WebApi/controllers/SurveyController.cs` `Submit&#40;&#41;`)

[//]: # (  * `src/Application/Survey/Commands/SurveyCommandHandler.cs` `Handle&#40;&#41;`)

[//]: # (* `POST /api/simulator`)

[//]: # (  * `src/WebApi/controllers/SimulatorController.cs` `Submit&#40;&#41;`)

[//]: # (  * `src/Application/Survey/Commands/SurveyCommandHandler.cs` `Handle&#40;&#41;`)