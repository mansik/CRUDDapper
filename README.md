# CRUDDapper

[C# Tutorial Insert Update Delete View data from database using Dapper CRUD ADO NET FoxLearn](https://youtu.be/pn8wrK3FyGA?si=WnoAhCHZ5CCy_ggz)

## 설명: CRUD Dapper(테이블 클래스, DataGridView 데이터 원본을 클래스로 선택, Stored Procedure)
* DataGridView클릭시 코딩없이 input 컨트롤에 데이터 연동
* DataGridView에 데이터 원본을 클래스로 선택,  input 컨트롤에 DataBinding을 연결
* 
* C# Mini Project CRUD Insert Update Delete and View Student Profile data from SQL database 
* using ADO.NET Dapper ORM, Stored Procedure in C# step by step

## 환경
* Visual Studio: [ ] 2019, [x] 2022
* 프로젝트 생성: [ ] .Net Framework, [x] .Net WinForm(windows form)
* Package 
  * [ ] DevExpress 18.2
* NuGet
  * [x] System.Data.SqlClient
  * [x] Dapper


## 작업
* Student.cs: class는 반드시 public로 선언해야 DataGridView에 데이터 원본 선택시 나타난다.(studentBindingSource가 생성됨)
* DataGridView에서 데이터 원본 선택 -> 데이터 원본 형식이름 Student를 선택하면 DataGridView의 컬럼이 나타난다.
* txtStudentID, txtFullName, txtBirthday, txtEmail, txtAddress의 컨트롤의 속성 
* -> DataBindings-> Text를 studentBindingSource의 각 컬럼명을 선택한다.
* chkGender 컨트롤의 속성 -> DataBindings-> Checked를 studentBindingSource의 Gender컬럼으로 선택한다.
