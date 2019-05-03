/*! demo.js | Bulkit | CSS Ninja */

/* ==========================================================================
Demo pages JS file 
========================================================================== */

$(document).ready(function($){
    
    "use strict";

    //Code highlight init
    $('pre code').each(function(i, block) {
        hljs.highlightBlock(block);
    });

    //Scrollspy nav init
    if ($('#scrollnav').length) {
        var sticky = new Waypoint.Sticky({
            element: $('#scrollnav')[0]
        })
        $(".scrollnav-tabs").scrollspy({ 
            offset: -25,
            activeClass: 'is-active'
        });
    }

    //Show and hide code accordion
    $('.accordion-wrapper .trigger a').on("click", function(){
        $(this).html('<i class="im im-icon-Coding is-icon-2x"></i> HIDE CODE<i class="im im-icon-Add"></i>');
        $('.trigger.active a').html('<i class="im im-icon-Coding is-icon-2x"></i> SHOW CODE<i class="im im-icon-Add"></i>');
    })

    //Animated Vivus svg hero illustrations for component pages
    if ($('#buttons').length) {
        //trigger svg animations
        new Vivus('buttons', {
            duration: 300, 
            file: 'assets/images/illustrations/components/buttons.svg'
        });
    }
    if ($('#tabs-ill').length) {
        //trigger svg animations
        new Vivus('tabs-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/tabs.svg'
        });
    }
    if ($('#inputs-ill').length) {
        //trigger svg animations
        new Vivus('inputs-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/inputs.svg'
        });
    }
    if ($('#cards-ill').length) {
        //trigger svg animations
        new Vivus('cards-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/cards.svg'
        });
    }
    if ($('#modals-ill').length) {
        //trigger svg animations
        new Vivus('modals-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/modals.svg'
        });
    }
    if ($('#accordion-ill').length) {
        //trigger svg animations
        new Vivus('accordion-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/accordion.svg'
        });
    }
    if ($('#dropdowns-ill').length) {
        //trigger svg animations
        new Vivus('dropdowns-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/dropdowns.svg'
        });
    }
    if ($('#lists-ill').length) {
        //trigger svg animations
        new Vivus('lists-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/lists.svg'
        });
    }
    if ($('#badges-ill').length) {
        //trigger svg animations
        new Vivus('badges-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/badges.svg'
        });
    }
    if ($('#popups-ill').length) {
        //trigger svg animations
        new Vivus('popups-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/popups.svg'
        });
    }
    if ($('#tables-ill').length) {
        //trigger svg animations
        new Vivus('tables-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/tables.svg'
        });
    }
    if ($('#timeline-ill').length) {
        //trigger svg animations
        new Vivus('timeline-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/timeline.svg'
        });
    }
    if ($('#boxes-ill').length) {
        //trigger svg animations
        new Vivus('boxes-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/boxes.svg'
        });
    }
    if ($('#messages-ill').length) {
        //trigger svg animations
        new Vivus('messages-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/messages.svg'
        });
    }
    if ($('#controls-ill').length) {
        //trigger svg animations
        new Vivus('controls-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/controls.svg'
        });
    }
    if ($('#forms-ill').length) {
        //trigger svg animations
        new Vivus('forms-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/forms.svg'
        });
    }
    if ($('#uploader-ill').length) {
        //trigger svg animations
        new Vivus('uploader-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/uploader.svg'
        });
    }
    if ($('#icons-ill').length) {
        //trigger svg animations
        new Vivus('icons-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/icons.svg'
        });
    }
    if ($('#features-ill').length) {
        //trigger svg animations
        new Vivus('features-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/features.svg'
        });
    }
    if ($('#pricing-ill').length) {
        //trigger svg animations
        new Vivus('pricing-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/pricing.svg'
        });
    }
    if ($('#team-ill').length) {
        //trigger svg animations
        new Vivus('team-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/team.svg'
        });
    }
    if ($('#testimonials-ill').length) {
        //trigger svg animations
        new Vivus('testimonials-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/testimonials.svg'
        });
    }
    if ($('#clients-ill').length) {
        //trigger svg animations
        new Vivus('clients-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/clients.svg'
        });
    }
    if ($('#counters-ill').length) {
        //trigger svg animations
        new Vivus('counters-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/counters.svg'
        });
    }
    if ($('#carousel-ill').length) {
        //trigger svg animations
        new Vivus('carousel-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/carousel.svg'
        });
    }
    if ($('#grid-ill').length) {
        //trigger svg animations
        new Vivus('grid-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/grid.svg'
        });
    }
    if ($('#footer-ill').length) {
        //trigger svg animations
        new Vivus('footer-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/footer.svg'
        });
    }
    if ($('#typography-ill').length) {
        //trigger svg animations
        new Vivus('typography-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/typography.svg'
        });
    }
    if ($('#colors-ill').length) {
        //trigger svg animations
        new Vivus('colors-ill', {
            duration: 300, 
            file: 'assets/images/illustrations/components/colors.svg'
        });
    }

    //Navbar styles panel 
    if ($('#nav-switch').length) {

        var navID;
        var colorID;
        
        //open panel
        $('#nav-switch').on("click", function(){
            $(this).addClass('is-active');
            $('.nav-switch-panel').removeClass('is-hidden')
        })
        //close panel
        $('#close-panel').on("click", function(){
            $('#nav-switch').removeClass('is-active');
            $('.nav-switch-panel, .nav-color-panel').addClass('is-hidden')
        })
        //Highlight selected option
        $('.switch-option').on("click", function(){
            $('.nav-color-panel').addClass('is-hidden');
            $('.switch-option.is-active').removeClass('is-active');
            $(this).addClass('is-active');
        })
        //Get the corresponding navbar
        $('.switch-option').on("click", function(){
            navID = $(this).attr('data-nav-style');
            $('.nav-style-option').addClass('is-hidden');
            $('#' + navID).removeClass('is-hidden');
        })
        //Color selector
        $('.switch-option.color-options').on("click", function(){
            $('.nav-color-panel').removeClass('is-hidden');
        })
        $('.color-picker-item').on("click", function(){
            colorID = $(this).attr('data-nav-style');
            $('.nav-reverse').addClass('is-hidden');
            $('#' + colorID).removeClass('is-hidden');
        })
    }

    //Toggle between light and dark logo when solid navbar comes in
    $(window).on('scroll', function () {    // this will work when your window scrolled.
        var height = $(window).scrollTop();  //getting the scrolling height of window
        if(height  > 80) {
            $("img.light-logo").attr("src","assets/images/logos/bulkit-logo.png");
        } else{
            $("img.light-logo").attr("src","assets/images/logos/bulkit-w.png");
        }
    });

    if ($('.navbar-light').length) {
        $(window).on('scroll', function () {    // this will work when your window scrolled.
            var height = $(window).scrollTop();  //getting the scrolling height of window
            if(height  > 80) {
                $('.button-signup').removeClass('light-btn').addClass('secondary-btn');
            } else{
                $('.button-signup').removeClass('secondary-btn').addClass('light-btn');
            }
        }); 
    }

    if ($('.is-title-reveal, .is-feature-reveal ').length) {
        
        //Scroll reveal definitions
        // Declaring defaults
        window.sr = ScrollReveal();

        // Simple reveal
        sr.reveal('.is-title-reveal', { 
            origin: 'bottom',
            distance: '20px',
            duration: 600,
            delay: 100,
            rotate: { x: 0, y: 0, z: 0 },
            opacity: 0,
            scale: 1,
            easing: 'cubic-bezier(0.215, 0.61, 0.355, 1)',
            container: window.document.documentElement,
            mobile: true,
            reset: false,
            useDelay: 'always',
            viewFactor: 0.2,

        });

        // Revealing features
        sr.reveal('.is-feature-reveal', { 
            origin: 'bottom',
            distance: '20px',
            duration: 600,
            delay: 100,
            rotate: { x: 0, y: 0, z: 0 },
            opacity: 0,
            scale: 1,
            easing: 'cubic-bezier(0.215, 0.61, 0.355, 1)',
            container: window.document.documentElement,
            mobile: true,
            reset: true,
            useDelay: 'always',
            viewFactor: 0.2,

        }, 160);
    }
})


