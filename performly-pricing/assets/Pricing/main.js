$(document).ready(function () {
    $("#intraBtn > li").click(function () {
        $("#talentBtn > li").removeClass('active');
        $("#intraBtn > li").addClass('active');
        $("#talent").removeClass('fade in active');
        $("#intra").addClass(" fade in active");

        $("#intramonthly").trigger("click");
    });

    $("#talentBtn > li" ).click(function () {
        $("#intraBtn > li").removeClass('active');
        $("#talentBtn > li").addClass('active');
        $("#intra").removeClass('fade in active');
        $("#talent").addClass("fade in active");

        $("#talentmonthly").trigger("click");

    });

    // Talent yearly
    $("#talentmonth").click(function () {
        $("#FTTP").html(2 * 0.9)
        $("#STTP").html(1.5 * 0.9)
        $("#TTTP").html(1.2 * 0.9)
        $("#FPTTP").html(1 * 0.9)

        $(".ACWT").show();
    })

    // Talent Monthly
    $("#talentmonthly").click(function () {
        $("#FTTP").html(2)
        $("#STTP").html(1.5)
        $("#TTTP").html(1.2)
        $("#FPTTP").html(1)
        $(".ACWT").hide();

    })

    //Yearly
    $("#intramonth").click(function () {
        // Team Bacage in yearly
        $("#FITP").html(1*0.9)
        $("#SITP").html(0.9 * 0.9)
        $("#TITP").html(0.7 * 0.9)
        $("#FPITP").html(0.5 * 0.9)

        // Business Bacage in yearly
        $("#B_FITP").html(2 * 0.9)
        $("#B_SITP").html(1.5 * 0.9)
        $("#B_TITP").html(1.2 * 0.9)
        $("#B_FPITP").html(1 * 0.9)

        // Enterprise Bacage in yearly
        $("#E_FITP").html(3 * 0.9)
        $("#E_SITP").html(2.5 * 0.9)
        $("#E_TITP").html(2 * 0.9)
        $("#E_FPITP").html(1.5 * 0.9)

        $("#PRP").html('$' + 1 * 0.9)
        $(".ACWI").show();

    })

    //Monthly
    $("#intramonthly").click(function () {
        // Team Backage in montly
        $("#FITP").html(1)
        $("#SITP").html(0.9)
        $("#TITP").html(0.7)
        $("#FPITP").html(0.5)

        // Business Bacage in montly
        $("#B_FITP").html(2)
        $("#B_SITP").html(1.5)
        $("#B_TITP").html(1.2)
        $("#B_FPITP").html(1)

        // Enterprise Bacage in yearly
        $("#E_FITP").html(3)
        $("#E_SITP").html(2.5)
        $("#E_TITP").html(2)
        $("#E_FPITP").html(1.5)

        $("#PRP").html('$' + 1)
        $(".ACWI").hide();


    })

    $("#FT > li").click(function () {
        $("#ST > li").removeClass('active');
        $("#TT > li").removeClass('active');
        $("#FTP > li").removeClass('active');
        $("#FT > li").addClass('active');

        $(".STB").removeClass('fade in active');
        $(".TTB").removeClass('fade in active');
        $(".FTBP").removeClass('fade in active');
        $(".FTB").addClass('fade in active');
    });

    $("#ST > li").click(function () {
        $("#FT > li").removeClass('active');
        $("#TT > li").removeClass('active');
        $("#FTP > li").removeClass('active');
        $("#ST > li").addClass('active');

        $(".FTB").removeClass('fade in active');
        $(".TTB").removeClass('fade in active');
        $(".FTBP").removeClass('fade in active');
        $(".STB").addClass('fade in active');
    });

    $("#TT > li").click(function () {
        $("#FT > li").removeClass('active');
        $("#ST > li").removeClass('active');
        $("#FTP > li").removeClass('active');
        $("#TT > li").addClass('active');

        $(".STB").removeClass('fade in active');
        $(".FTB").removeClass('fade in active');
        $(".FTBP").removeClass('fade in active');
        $(".TTB").addClass('fade in active');
    });

    $("#FTP > li").click(function () {
        $("#FT > li").removeClass('active');
        $("#ST > li").removeClass('active');
        $("#TT > li").removeClass('active');
        $("#FTP > li").addClass('active');

        $(".STB").removeClass('fade in active');
        $(".FTB").removeClass('fade in active');
        $(".TTB").removeClass('fade in active');
        $(".FTBP").addClass('fade in active');
    });


})
