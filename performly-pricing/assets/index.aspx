<%@ Page Title="" Language="C#" MasterPageFile="~/performlyWebsite.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PerformlyWebsite.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <!-- Body -->
   
      <!-- everything -->
      <!-- alert -->
      <div class="container-fluid page full" style="padding-bottom: 0; margin-top:60px">
      </div>
      <div class="row" style="position:relative; margin:0">
		<img style="width:100%;" src="./assets/images/home-banner.jpg" alt="Home banner">
		<div id="empowering_talents" class="title" style="padding-left:10px; ">
			<p>Empowering <br> Talents.</p>
		</div>
		<div class="description" style="padding-top:10px">
			<p>Transform your Workplace<br> Productivity &amp; Engagement <br>through our Web-based and<br> Mobile App Solution.</p></div>
		<div class="demo" style="margin-top:20px"><a data-toggle="modal" data-target="#editModal" data-remote="/demorequests/new #modal-new-fields" style="color: inherit;text-decoration: inherit;cursor: pointer;
        cursor: hand;">Get Free Demo</a></div>
</div>


<div class="row" style="background-color:#e2e7ed; margin:0;">

	<div class="col-md-6 col-sm-6 col-xs-12">
		<div class="intro">
			<div class="title2">More than<br class="mobileView"> Performance<br class="mobileView"> Management</div>
			<div style="margin-top:20px;">

				<div class="parent">
				<div id="watch" class="vid readmore" style="float:left;">Watch More<span class="glyphicon glyphicon-chevron-right" style="color:#ff6c00; font-size:23px;"></span></div>
			</div>
			</div>
		</div>
	</div>

	<div class="col-md-6 col-sm-6 col-xs-12">
        <!--<iframe width="100%" height="376" src="https://www.youtube.com/embed/b4hP51_gvDM?rel=0&amp;autoplay=1" frameborder="0" allowfullscreen=""></iframe>-->
    <div class="vid" id="removeme" style="float:right">
        <img style="float:right; cursor:pointer; cursor: hand;" class="img-responsive" src="./assets/images/demovideo.jpg" alt="Demovideo">
        </div> 
    </div>

</div>

<div class="row" style="margin:50px 0 0 0">
	<div class="col-md-6">
		<center>
			<img class="img-responsive" src="./assets/images/safaripreview.png" alt="Safaripreview c9fda00870f3ed19122202e345ce951f25c58551873f63faf6004cf207cee5b9">
		</center>
	</div>
	<div class="col-md-1"></div>
	<div class="col-md-5">
		<div class="heading" style="">Job profile &amp;<br>Goals Alignment</div>
		<div class="subheading" style=""><p>Use technology to prompt and <br> document your business profile.</p></div>
		<div class="row" style="margin-top:40px;">
			<span class="text-center col-md-3 col-sm-3 col-xs-3">
				<img style="" class="iconimg" src="./assets/images/objectives2.png" alt="Objectives2 ccc3449630e9575a3a77e682ecf5ec16a6e432350d339bf6f5eda3c0ad0b22c4">
				<p class="objdesc">Objectives</p>
			</span>

			<span class="text-center col-md-3 col-sm-3 col-xs-3">
				<img style="" class="iconimg" src="./assets/images/competencies3.png" alt="Competencies3 ">
				<p class="objdesc">Competencies</p>
			</span>
			<span class="text-center col-md-3 col-sm-3 col-xs-3">
				<img style="" class="iconimg" src="./assets/images/developmentplan3.png" alt="Developmentplan3 ">
				<p class="objdesc">Development<br>Plan</p>
			</span>
			<span class="text-center col-md-3 col-sm-3 col-xs-3"> 
				<img style="" class="iconimg" src="./assets/images/jobdescription2.png" alt="Jobdescription2 ">
				<p class="objdesc">Job<br>Description</p>
			</span>
		</div>
		<div style="margin-top:30px;">
			<div class="parent">
			<a href="/features/userprofile.aspx" class="readmore">Read More<span class="glyphicon glyphicon-chevron-right" style="color:#ff6c00; font-size:13px;"></span></a>
		</div>
		</div>
	</div>
</div>

<div class="row" style="margin:100px 0 0 0;">
	<div class="col-md-6 leftcol">
		<div class="heading">OnGoing Feedback <br>&amp; Coaching</div>
		<div class="subheading">
			<p>Shift the emphasis of performance <br>management from a once or twice yearly event to an ongoing conversations and Feedback.</p></div>
		<div style="margin-top:30px;">
			<div class="parent">
			<a href="/features/feedback.aspx" class="readmore">Read More<span class="glyphicon glyphicon-chevron-right" style="color:#ff6c00; font-size:13px;"></span></a>
			</div>
		</div>
	</div>
	<div class="col-md-2"></div>
	<div class="col-md-4">
		<center>
			<img class="img-responsive" src="./assets/images/iphonefeedback.png" alt="Iphonefeedback b730313bcfe18d9e6dbe733be909f488ac804817d28935b45ce7ba9842bcc1aa">
		</center>
	</div>
</div>

<div class="row" style="margin:100px 0 0 0">
	<div class="col-md-6">
		<center>
			<img class="img-responsive" src="./assets/images/360.png" alt="360 c7e6cff3b466e11a5867dd43ca82603ad5b24ded2c5e67b27216ba62d798614b">
		</center>
	</div>
	<div class="col-md-1"></div>
	<div class="col-md-5">
		<div class="heading">360º Reviews & Feedback</div>
		<div class="subheading"><p>Reviews from anyone and anytime <br>for better high performance culture <br>and full calibration.</p></div>
		<div class="row" style="margin-top:40px;">
			<span class="text-center col-md-3 col-sm-3 col-xs-3">
				<img style="" class="iconimg" src="./assets/images/reviews/self2.png" alt="Self2 ">
				<p class="objdesc">Self</p>
			</span>
			<span class="text-center col-md-3 col-sm-3 col-xs-3">
				<img style="" class="iconimg" src="./assets/images/reviews/sub2.png" alt="Sub2">
				<p class="objdesc">Sub</p>
			</span>
			<span class="text-center col-md-3 col-sm-3 col-xs-3">
				<img style="" class="iconimg" src="./assets/images/reviews/reverse2.png" alt="Reverse2">
				<p class="objdesc">Reverse</p>
			</span>
			<span class="text-center col-md-3 col-sm-3 col-xs-3"> 
				<img style="" class="iconimg" src="./assets/images/reviews/peers2.png" alt="Peers2">
				<p class="objdesc">Peers</p>
			</span>
		</div>
		<div style="margin-top:30px;">
			<div class="parent">
			<a href="/features/reviews.aspx" class="readmore">Read More<span class="glyphicon glyphicon-chevron-right" style="color:#ff6c00; font-size:13px;"></span></a>
			</div>
		</div>
	</div>
</div>

<div class="row" style="margin:100px 0 0 0">
	<div class="col-md-6 leftcol">
		<div class="heading">Meetings</div>
		<div class="subheading">
			<p>Have 1-on-1's CHECK-IN'S meetings<br> with ready templates attached to<br> discuss objectives progress and<br> feedback.</p>
		</div>
		<div style="margin-top:30px;">
			<div class="parent">
			<a href="/features/meetings.aspx" class="readmore">Read More<span class="glyphicon glyphicon-chevron-right" style="color:#ff6c00; font-size:13px;"></span></a>
			</div>
		</div>
	</div>
	<div class="col-md-2"></div>
	<div class="col-md-4">
		<center>
			<img style="" class="img-responsive" src="./assets/images/reflections.png" alt="Reflections">
		</center>
	</div>
</div>

<div class="row" style="margin:100px 0 0 0">
	<div class="col-md-6">
		<center>
		<img style="" class="img-responsive" src="./assets/images/recognition.png" alt="Recognition c358cfeccd2c35451ab42e61302c114116bff4236bd09e03d04e2a4c1e529245">
	</center>
	</div>
	<div class="col-md-1"></div>
	<div class="col-md-5">
		<div class="heading">Recognition</div>
		<div class="subheading">
			<p>Enable all the organization to <br>recognize each other, even for the<br> small victories.</p>
		</div>
		<div style="margin-top:30px;">
			<div class="parent">
			<a href="/features/recognition.aspx" class="readmore">Read More<span class="glyphicon glyphicon-chevron-right" style="color:#ff6c00; font-size:13px;"></span></a>
			</div>
		</div>
	</div>
</div>

<div class="row" style="margin:100px 0 0 0">
	<div class="col-md-6 leftcol">
		<div class="heading">Daily to do list</div>
		<div class="subheading">
			<p>Have your daily to do checklist in<br> performly and link each task to your <br> current objectives.</p>
		</div>
		<div style="margin-top:30px;">
			<div class="parent">
			<a href="/features/todo.aspx" class="readmore">Read More<span class="glyphicon glyphicon-chevron-right" style="color:#ff6c00; font-size:13px;"></span></a>
			</div>
		</div>
	</div>
	<div class="col-md-2"></div>
	<div class="col-md-4">
		<center>
		<img style="" class="img-responsive" src="./assets/images/todo.png" alt="Todo ">
	</center>
	</div>
</div>

<div id="survey" class="row" style="margin:100px 0 0 0; background-color:#e2e7ed; padding:20px 0;">
	<div class="col-md-6">
		<center>
			<div class="analytics"><img style="" class="img-responsive" src="./assets/images/survey.png" alt="Survey"></div>
		</center>
	</div>
	<div class="col-md-1"></div>
	<div class="col-md-5">
		<div class="heading">Analytics, Reports &amp; Surveys</div>
		<div class="subheading">
			<p>Performly generates variety of dashboards <br>that enable allorganizations members to <br> monitor organization Performance.</p></div>
		<div class="row text-center" style="margin-top:40px;">
			<span class="text-center col-md-2 col-sm-4 col-xs-4">
				<img style="height:47px;" src="./assets/images/reports/surveys2.png" alt="Surveys2">
				<p class="objdesc">Surveys</p>
			</span>

			<span class="text-center col-md-2 col-sm-4 col-xs-4">
				<img style="height:47px;" src="./assets/images/reports/reports2.png" alt="Reports2 ">				
				<p class="objdesc">Reports</p>
			</span>
			<span class="text-center col-md-2 col-sm-4 col-xs-4">
				<img style="height:47px;" src="./assets/images/reports/analytics2.png" alt="Analytics2 ">				
				<p class="objdesc">Analytics</p>
			</span>
		</div>
	</div>
</div>

<center style="color:#003faf; font-family:ProximaRegular; font-size:40px; margin-top:60px;">HAPPY CLIENTS</center>

<div class="row" style="margin:0 0 0 0; padding:5%">
			<div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-1.jpg" alt="Logo 1 ">
				</center>
			</div>
			<div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-2.jpg" alt="Logo 2 ">
				</center>
			</div>
			<div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-3.jpg" alt="Logo 3 ">
				</center>
			</div>
			<div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-4.jpg" alt="Logo 4 ">
				</center>
			</div>
			<div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-5.jpg" alt="Logo 5 ">
				</center>
			</div>
			<div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-6.jpg" alt="Logo 6 ">
				</center>
			</div>
			<div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-7.jpg" alt="Logo 7">
				</center>
			</div>
			<div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-8.jpg" alt="Logo 8 ">
				</center>
			</div>
			<div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-9.jpg" alt="Logo 9 ">
				</center>
			</div>
			<div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-10.jpg" alt="Logo 10 ">
				</center>
			</div>
			<div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-11.jpg" alt="Logo 11 ">
				</center>
			</div>
			<div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-12.jpg" alt="Logo 12 ">
				</center>
			</div>

    <div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-13.jpg" alt="Logo 13 ">
				</center>
			</div>

     <div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-14.jpg" alt="Logo 13 ">
				</center>
			</div>

     <div class="col-sm-3 col-xs-6" style="padding:0 0 0 0">
				<center><img style="width:100%" class="img-responsive" src="./assets/images/new_clients/Logo-15.jpg" alt="Logo 13 ">
				</center>
			</div>
</div>

<center style="color:#003faf; font-family:ProximaRegular; font-size:40px; margin-top:50px;">TESTIMONIALS</center>

<div class="news">
	<h4 id="title"></h4>
	<div class="row" style="margin:0">
		<span class="col-xs-1 col-sm-1 col-md-1 glyphicon glyphicon-chevron-left button-prev" style="direction:ltr;" id="button-next"></span>
		<span class="col-xs-10 col-sm-10 col-md-10" style="min-height: 150px"><p style="text-align:center;" id="news-text">
            
            
            
            <hr style="border-color:transparent; margin:3px;"></p></span>	
		<span class="col-xs-1 col-sm-1 col-md-1 glyphicon glyphicon-chevron-right button-next" style="" id="button-prev"></span>
	</div>
</div>

<center style="color:#003faf; font-family:ProximaRegular; font-size:40px; margin-top:100px;">PARTNERS</center>

<div class="row" style="margin:30px 0 0 0; padding:20px;">
		<div class="col-sm-6 col-xs-6"><center><a href="http://www.aspire.com.eg/"><img style="float:right;" class="img-responsive" src="./assets/images/aspire.jpg" alt="Aspire "></a></center></div>
		<div class="col-sm-6 col-xs-6"><center><a href="http://www.redrockinternational.com/eg/"><img style="float:left;" class="img-responsive" src="./assets/images/redrock.png" alt="Redrock dc6296ab0bbe7d83377387ea101e62a755aebea38bae4be991cc95abe8ac81ed"></a></center></div>
</div>

<script>
    // $( window ).resize(function() {
    // 	alert($(document).width())
    // });

    var news = []
    var newsCounter = 0

    // Missing Code: @news.all.each (get from kdec)


    news.push('<div class="row"><div class="col-md-2 col-sm-12 col-xs-12 text-center"><center><img class="img-responsive" src="/assets/images/nermin.png" alt="Nermin " /></center></div>' + "<div class='col-md-10 col-sm-12 col-xs-12' style='padding-left:20px;'><p style='font-family:ProximaLight; text-align:justify; margin-bottom:0px;'>Performly is a different in a way that all users are engaged and looking forward to use it, the user friendly and modern interface makes it  easy to use the app along with the multiple integrated fearures specially Task Management.</p><p style='font-family:ProximaRegularItalic; color:#003faf; text-align:justify; margin-top:10px; margin-bottom:0px;'> Nermine Faltas</p><p style='font-family:ProximaLightItalic; color:#003faf; text-align:justify;'>Human Resources Director - Orascom Development</p></div></div>");

    news.push('<div class="row"><div class="col-md-2 col-sm-12 col-xs-12 text-center"><center><img class="img-responsive" src="/assets/images/nader.png" alt="Nader " /></div></center>' + "<div class='col-md-10 col-sm-12 col-xs-12' style='padding-left:20px;'><p style='font-family:ProximaLight; text-align:justify; margin-bottom:0px;'>Performly provided us with a state-of-the-art performance management solution that allowed us to be on top of the latest trends in human resources management. It is a simple, innovative as well as highly customisable tool that adds tremendous value to our organisation. Performly is a great solution for any human resources department and I can definitely recommend it to any kind of company.</p><p style='font-family:ProximaRegularItalic; color:#003faf; text-align:justify; margin-top:10px; margin-bottom:0px;'>Nader Nabil</p><p style='font-family:ProximaLightItalic; color:#003faf; text-align:justify;'>HR Manager - Gleeds Construction Consultancy Egypt </p></div></div>");

    var t = document.getElementById("news-text");
    var text = news[0].split("dbcce5b3da")
    t.innerHTML = ""
    for (i = 0; i < text.length; i++) {
        t.innerHTML = t.innerHTML + text[i] + "<hr style='border-color:transparent; margin:3px;'>"
    }
    $('.button-prev').click(function () {

        if (newsCounter == 0) {
            newsCounter = news.length - 1
            $("#news-counter").html(newsCounter + 1)
        } else {
            $("#news-counter").html(newsCounter)
            newsCounter--
        }
        // $("#news-text").html(news[newsCounter])
        var t = document.getElementById("news-text");
        var text = news[newsCounter].split("dbcce5b3da")
        t.innerHTML = ""
        for (i = 0; i < text.length; i++) {
            t.innerHTML = t.innerHTML + text[i] + "<hr style='border-color:transparent; margin:3px;'>"
        }
    });

    $('.button-next').click(function () {

        if (newsCounter == news.length - 1) {
            newsCounter = 0
        } else {
            newsCounter++
        }
        $("#news-counter").html(newsCounter + 1)
        // $("#news-text").html(news[newsCounter])
        var t = document.getElementById("news-text");
        var text = news[newsCounter].split("dbcce5b3da")
        t.innerHTML = ""
        for (i = 0; i < text.length; i++) {
            t.innerHTML = t.innerHTML + text[i] + "<hr style='border-color:transparent; margin:3px;'>"
        }
    });
    $('.vid').click(function () {
        video = '<iframe width="100%" height="376" src="https://www.youtube.com/embed/b4hP51_gvDM?rel=0&autoplay=1" frameborder="0" allowfullscreen></iframe>';
        $('#removeme').replaceWith(video);
    });

</script>

<style>

@media (min-width: 726px){
	#empowering_talents{
		

	}
}
</style>
   
    <!-- Demo Request Modal -->
  
    <!-- footer  -->
    
  


</asp:Content>