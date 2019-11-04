console.log('%c ', 'font-size:500px; background:url(https://upload.wikimedia.org/wikipedia/commons/2/26/Gaius_Julius_Caesar_%28100-44_BC%29.JPG) no-repeat;');
console.log('https://kk.wikipedia.org/wiki/%D0%A6%D0%B5%D0%B7%D0%B0%D1%80%D1%8C_%D1%88%D0%B8%D1%84%D1%80%D1%8B#%D2%9A%D0%BE%D0%BB%D0%B4%D0%B0%D0%BD%D1%83_%D1%82%D0%B0%D1%80%D0%B8%D1%85%D1%8B')
$(document).ready(function(){
    $(".button").click(function(){
      $("nav").hide();
      $("img").hide(1500);
      $("h1").hide();
      $(".content>.content-img").hide();
      $(".content>.content-img>img").hide();
      $(".content > p").hide();
      $("hr").hide();
      $(".box>p").animate({
        color: 'black',
        fontSize: '2.5em',
        },"slow");
      $("#bg").show(800);
    });
  });