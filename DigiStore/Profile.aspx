﻿<html class="" lang="en">
<head>
    <title>DigiStore - Profile</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1.0" />


    <!-- All the sources needed and try and make it look pretty -->
    <!-- Compiled and minified CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.7/css/materialize.min.css">

    <!-- Compiled and minified JavaScript -->
    <!--
      SO jQuery must be loaded before materialize. I will never forget this, and nither should you!  
      -->
    <script src="https://code.jquery.com/jquery-2.2.4.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.7/js/materialize.min.js"></script>

    <!-- Materialize Icons -->
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">

    <!-- Custom CSS  -->
    <link href="css/style.css" type="text/css" rel="stylesheet" media="screen,projection" />

</head>

<body>
    <nav class="blue darken-3" role="navigation">
        <div class="nav-wrapper container">
            <a id="logo-container" href="#" class="brand-logo center yellow-text accent-3">DigiStore</a>
            <ul class="right hide-on-med-and-down">
                <li><a href="#" class="yellow-text accent-3">Home</a></li>
                <li><a href="#" class="yellow-text accent-3">Search</a></li>
                <li><a href="#" class="yellow-text accent-3">Sales</a></li>
                <li><a class="dropdown-button centered" href="#" data-activates="accountDropdown">
                    <img class="circle" src="/img/icon.png" height="30" width="30" /></a></li>
            </ul>

            <ul id="nav-mobile" class="side-nav">
                <h4 class="center blue-text darken-3">Menu</h4>
                <li>
                    <div class="divider"></div>
                </li>
                <li><a href="#">Home</a></li>
                <li><a href="#">Browse</a></li>
                <li><a href="#">Cart</a></li>
                <li>
                    <div class="divider"></div>
                </li>
                <li><a href="#">Manage Store</a></li>
                <li><a href="#">Order History</a></li>
                <li><a href="#">Settings</a></li>
                <li><a href="#">Log In/Out</a></li>
            </ul>
            <a href="#" data-activates="nav-mobile" class="button-collapse"><i class="material-icons">menu</i></a>

            <ul id="accountDropdown" class="dropdown-content">
                <li>Manage Profile</li>
                <li>View Cart</li>
                <li>Order History</li>
                <li>Settings</li>
                <li>Log In/Out</li>
            </ul>
        </div>
    </nav>



    <div class="container">
        <div class="section">

            <div class="row">
                <div class="section no-pad-bot" id="index-banner">
                    <h1 class="header center blue-text darken-3">Username's Profile</h1>
                </div>
                <ul class="collapsible" data-collapsible="accordion">
                    <li>
                        <div class="collapsible-header active"><i class="material-icons">settings</i>General</div>
                        <div class="collapsible-body">

                            <p>
                                <label for="firstname">First Name</label>
                                <input placeholder="Bob" id="firstname" type="text" class="validate">
                                <label for="lastname">Last Name</label>
                                <input placeholder="Barker" id="lastname" type="text" class="validate">
                                <label for="email">Email</label>
                                <input placeholder="bobbarker@gmail.com" id="email" type="text" class="validate">
                                <label for="addresStreet">Street</label>
                                <input placeholder="555 Main St." id="addressStreet" type="text" class="validate">
                                <label for="addressCity">Town/City</label>
                                <input placeholder="Toronto" id="addressCity" type="text" class="validate">
                                <label for="addressProvince">State/Province</label>
                                <input placeholder="Ontario" id="addressProvince" type="text" class="validate">
                                <label for="addressPostal">Address</label>
                                <input placeholder="H0H0H0" id="addressPostal" type="text" class="validate">
                                <a class="waves-effect waves-light btn blue darken-3 yellow-text accent-3">Save Changes</a>
                            </p>
                        </div>
                    </li>
                    <li>
                        <div class="collapsible-header"><i class="material-icons">lock</i>Change Password</div>
                        <div class="collapsible-body">
                            <p>
                                <label for="old_pass">Old Password</label>
                                <input placeholder="Old Password" id="old_pass" type="text" class="validate">
                                <input placeholder="New Password" id="new_pass" type="text" class="validate">
                                <input placeholder="Confirm Password" id="confirm_pass" type="text" class="validate">
                                <br />
                                <a class="waves-effect waves-light btn blue darken-3 yellow-text accent-3">Save Changes</a>
                            </p>
                        </div>
                    </li>
                    <li>
                        <div class="collapsible-header"><i class="material-icons">credit_card</i>Payment</div>
                        <div class="collapsible-body">
                            <p>
                                <label for="cardholder">Cardholder Name</label>
                                <input placeholder="Bob Barker" id="cardholder" type="text" class="validate">
                                <label for="card_number">Card Number</label>
                                <input placeholder="5555 5555 5555 5555" id="card_number" type="text" class="validate">
                                <label for="expiry">Expiry Date</label>
                                <input placeholder="TODAY!!?!??!" id="expiry" type="text" class="validate">
                                <br />
                                <a class="waves-effect waves-light btn blue darken-3 yellow-text accent-3">Save Changes</a>
                            </p>
                        </div>
                    </li>

                </ul>
            </div>
        </div>
    </div>

    <footer class="page-footer blue darken-3">
        <div class="container">
            <div class="row">
                <div class="col l6 s12">
                    <h5 class="yellow-text accent-3">Company Bio</h5>
                    <p class="grey-text text-lighten-4">We are a team of college students working on this project like it's our full time job. Any amount would help support and continue development on this project and is greatly appreciated.</p>


                </div>
                <div class="col l3 s12">
                    <h5 class="yellow-text">Settings</h5>
                    <ul>
                        <li><a class="white-text" href="#!">Link 1</a></li>
                        <li><a class="white-text" href="#!">Link 2</a></li>
                        <li><a class="white-text" href="#!">Link 3</a></li>
                        <li><a class="white-text" href="#!">Link 4</a></li>
                    </ul>
                </div>
                <div class="col l3 s12">
                    <h5 class="yellow-text">Connect</h5>
                    <ul>
                        <li><a class="white-text" href="#!">Link 1</a></li>
                        <li><a class="white-text" href="#!">Link 2</a></li>
                        <li><a class="white-text" href="#!">Link 3</a></li>
                        <li><a class="white-text" href="#!">Link 4</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="footer-copyright">
            <div class="container">
                Made by <a class="yellow-text accent-3" href="http://materializecss.com">Materialize</a>
            </div>
        </div>
    </footer>


    <script type="text/javascript" src="js/init.js"></script>

</body>
</html>

