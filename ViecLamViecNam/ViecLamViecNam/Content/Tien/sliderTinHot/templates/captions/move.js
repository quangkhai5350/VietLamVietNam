// -----------------------------------------------------------------------------------
// http://wowslider.com/
// JavaScript Wow Slider is a free software that helps you easily generate delicious 
// slideshows with gorgeous transition effects, in a few clicks without writing a single line of code.
// Generated by $AppName$ $AppVersion$
//
//***********************************************
// Obfuscated by Javascript Obfuscator
// http://javascript-source.com
//***********************************************
(function(){var a;window.ws_caption_move=function(j,h,d,f){var c=jQuery;var g=[{left1:"100%",top2:"100%"},{left1:"80%",left2:"-50%"},{top1:"-100%",top2:"100%",distance:0.7,easing:"easeOutBack"},{top1:"-80%",top2:"-80%",distance:0.3,easing:"easeOutBack"},{top1:"-80%",left2:"80%"},{left1:"80%",left2:"80%"}];g=g[Math.floor(Math.random()*g.length)];var b=0.5;var e="easeOutElastic1";var i=j.noDelay?0:(j.duration/2-j.captionDuration/3);if(i<0){i=0}h.stop(1,1).delay(i).fadeOut(j.captionDuration/3);if(f){if(a){clearTimeout(a)}a=setTimeout(function(){h.stop(1,1).html(f);var m=h.find(">span,>div").get();c(m).css({position:"relative",visibility:"hidden"});h.show();for(var n in g){if(/\%/.test(g[n])){g[n]=parseInt(g[n])/100;var o=h.offset()[/left/.test(n)?"left":"top"];var l=/left/.test(n)?"width":"height";if(g[n]<0){g[n]*=o}else{g[n]*=j.$this[l]()-h[l]()-o}}}c(m[0]).css({left:(g.left1||0)+"px",top:(g.top1||0)+"px"});c(m[1]).css({left:(g.left2||0)+"px",top:(g.top2||0)+"px"});function k(p){var q=c(m[p]).css("opacity");c(m[p]).css({visibility:"visible"}).css({opacity:0}).animate({opacity:q},j.captionDuration,"easeOutCirc").animate({top:0,left:0},{duration:j.captionDuration,easing:(g.easing||e),queue:false})}k(0);setTimeout(function(){k(1)},j.captionDuration*(g.distance||b))},j.noDelay?0:(j.duration/2+i))}}}());