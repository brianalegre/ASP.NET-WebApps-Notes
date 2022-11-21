@page
@model MyApp.Namespace.ProfileModel
@{
}

< div class= "container" >

    < div class= "row" >

        < div class= "col-12" >

            < div class= "card" >

                < div class= "card-body" >

                    < div class= "card-title mb-4" >

                        < div class= "d-flex justify-content-start" >

                            < div class= "image-container" >

                                < img src = "http://placehold.it/150x150" id = "imgProfile" style = "width: 150px; height: 150px" class= "img-thumbnail" />

                            </ div >

                            < div class= "userData ml-3" >

                                < h2 class= "d-block" style = "font-size: 1.5rem; font-weight: bold" >
                < !--Username Here-- >
                @ViewData["username"]

                </ h2 >

                            </ div >

                        </ div >

                    </ div >


                    < div class= "row" >

                      < div class= "col-12" >

                          < ul class= "nav nav-tabs mb-4" id = "myTab" role = "tablist" >

                              < li class= "nav-item" >

                                    < a class= "nav-link active" href = "#" > Basic Info </ a >

                                </ li >

                            </ ul >


                          < div class= "tab-content ml-1" id = "myTabContent" >

                              < div class= "tab-pane fade show active" id = "basicInfo" aria - labelledby = "basicInfo-tab" >

                                    < div class= "row" >

                                        < div class= "col-sm-3 col-md-2 col-5" >

                                            < label style = "font-weight:bold;" > Full Name </ label >

                                        </ div >
                    < div class= "col-md-8 col-6" >
                    < !--Your Name Here -->
                      @ViewData["myName"]

                    </ div >

                                    </ div >

                                    < hr />

                  < div class= "row" >
                    < div class= "col-sm-3 col-md-2 col-5" >
                      < label style = "font-weight:bold;" > Age </ label >
                    </ div >
                    < div class= "col-md-8 col-6" >
                      < !--Your Age Here -->
                      @ViewData["myAge"]


                    </ div >
                  </ div >

                                    < hr />

                  < div class= "row" >
                      < div class= "col-sm-3 col-md-2 col-5" >
                          < label style = "font-weight:bold;" > Occupation </ label >
                      </ div >
                      < div class= "col-md-8 col-6" >
                        < !--Your Occupation Here -->
                        @ViewData["myOccupation"]


                      </ div >
                  </ div >
                  < hr />


                  < div class= "row" >
                    < div class= "col-sm-3 col-md-2 col-5" >
                      < label style = "font-weight:bold;" > Current Date </ label >
                    </ div >
                      < div class= "col-md-8 col-6" >
                        < !--Current Date Here -->
                        @ViewData["currentDate"]


                      </ div >
                  </ div >
                < hr />

                            </ div >

                        </ div >

                    </ div >

                </ div >

            </ div >
    </ div >
  </ div >
</ div >