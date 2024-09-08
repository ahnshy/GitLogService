# ⚙️Git Log Service <br/>
 This is a RESTful API Windows service program that statistically returns Git Log to json. (without express)
<br/>
<br/>
<br/>

## 📢 [Overview]
- It operates as a Windows background service and runs without the need to log in to a Windows user session.
- Statistics in the Git Log operate as of the date you set config.
<br/>

## 🛠️ Stacks
<img src="https://img.shields.io/badge/-C%23-000000?logo=dotnet" /> <img src="https://img.shields.io/badge/JSON-000000?logo=json&logoColor=white" /><br/> RESTful API Consumer(https://github.com/ahnshy/GitStatisticsGraph) : <img src="https://img.shields.io/badge/vue.js-%2335495e.svg?&logo=vuedotjs&logoColor=%234FC08D" /> <img src="https://img.shields.io/badge/html5-%23E34F26.svg?&logo=html5&logoColor=white" /> <img src="https://img.shields.io/badge/CSS3-1572B6?logo=css3&logoColor=white"/><br/><br/>

## 🚩 [Objective]
- What would you do with the evaluation of a hard-working developer and a cheated developer?
- Use it as an indicator of fair evaluation within the organization.
- I've worked hard, but the results aren't always good. So, if you refer to documents, ALM, Red mime, Jira, WIKI, etc. in addition to Git Log, you will be able to conduct a more accurate developer evaluation.
<br/>

## 🛠️ [Technologies]
- **C#**: Object-oriented programming languages announced with the NET project.
- **Windows Service**: Windows service runs when the Microsoft Windows operating system is started and does not require user interference, and runs in background mode as long as Windows is running.
- **RESTful API**: It is an application development interface that provides access to resources based on HTTP and URI.
- **JSON**: JavaScript Object Notation (JSON) is a character-based standard format for representing structured data in JavaScript object grammar.

- Git Log statistics using this service will be implemented additionally with html5, css3, and vue3.js.
- Please refer to the following for the corresponding repertoire, it is currently being implemented.(https://github.com/ahnshy/GitStatisticsGraph)
<br/>

## ⚙️ [Instructions]

[Register Window Service]
```bash
  sc create "Git Log service" binPath= "C:\Program Files (x86)\GitLogService\GitLogService.exe"
```

[Remove Window Service]
```bash
  NET STOP "Git Log service"
  sc delete "Git Log service"
```

[Run]
```bash
  NET START "Git Log service"
```
<br/>

## 📌 [Advanced Features]
* It is recommended to automatically post Git Log statistics once a week in conjunction with the JIRA API to publish and disclose them periodically.
* It is better to send mail registered with the SMTP protocol to mail registered with the publication.
* Git Log should be reviewed. Some developers artificially uploaded statistics with gaps or annotation for performance.
<br/>

## 💻 [Demo and Preview]
>
> [Notice]
>The service is being implemented. 
> <br/>
> Once completed, we will demonstrate the demo by capturing the screen.<br/>
>
<br/>
<br/>
