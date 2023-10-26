<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Student Registration </title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <div class="container" style="height: 100%; width: 100%;" >

        <div class="color">
            <div class="logo">
                <img src="picture/University of Kotli.png" alt="" width="80px">
              </div>
            <div class="heading" >
                <h2>Hostel Management System</h2>
            </div>
       </div>
       <div class="nav">
                  <li>
                    <a href="index.html"><b>Home</b></a> &nbsp;
                    <a href="contact.html"><b>Contact</b></a> &nbsp;
                    <a href=""><b>About</b></a> &nbsp;
                  </li>
             </div>
      </div>
      <!---form code-->
      <div class="Reg_form">
        <h2 style="text-align: center; background-color: brown;">Registration Form</h2>
        <form action="" method="post">
            <p style="text-align: center;"><b><span>Personal Information</span></b></p>
            <hr>
            <p style="text-align: center;"><b>First Name:</b><input type="text" required></p>
            <p style="text-align: center;"><b>Last Name:</b><input type="text"required></p>
            <p style="text-align: center;"><b>Father Name:</b><input type="text"required></p>
            <p style="text-align: center;"><b>CNIC:</b><input type="text"required></p>
            <p style="text-align: center;"><b>DOB:</b><input type="datetime" required></p>
            <p style="text-align: center;"><b>Status:</b>
                <select name="status" id="status">
                    <option value="">---select choice--</option>
                    <option value="Single">Single</option>
                    <option value="Married">Married</option>
                </select>
            </p>
            <hr>
            <p style="text-align: center;"><b><span>Contact Information</span></b></p>
            <hr>
            <p style="text-align: center;"><b>Address:</b><input type="text"required></p>
            <p style="text-align: center;"><b>Email:</b><input type="email"required></p>
            <p style="text-align: center;"><b>Contact:</b><input type="text"required></p>
            <hr>
            <p style="text-align: center;"><b></b><input type="submit"></p>
        </form>
        
       </div>
       <!---Main Picute-->
<div class="MianPic">
    <h2 style="text-align: center;">Hostel Building</h2>
         <img src="picture/reg building.jpg" alt="" width="750px" height="650px">
     
   </div>
      

</body>
</html>