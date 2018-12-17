var sanpham = [
    {
        hinh:"img/sp1.jpg",
        ten:"Converse Chuck 2 cổ cao",
        gia: "800.000 VNĐ",
        link: "ConverseChuck2cocao.html"
    },
    {
        hinh:"img/sp2.jpg",
        ten:"Giày Thể Thao Biti's ",
        gia: '533.000VNĐ',
        link:"GiayTheThaoBiti's.html"
    },
    {
        hinh:"img/sp3.jpg",
        ten:"Chuck Taylor Classic",
        gia: '900.000VNĐ',
        link:"ChuckTaylorClassic.html"
    },
    {
        hinh:"img/sp5.jpg",
        ten:"Giày Adidas 7 màu Đặc biệt ",
        gia: '540.000VNĐ',
        link:"GiayAdidas7mauĐacbiet.html"
    },
    {
        hinh:"img/sp6.jpg",
        ten:"Biti's hunter giành cho nữ Original",
        gia: '660.000VNĐ',
        link:"Biti'shuntergianhchonuOriginal.html"
    },

    {
        hinh:"img/sp4.jpg",
        ten:"Converse chuck 2 all star full đen",
        gia: '560.000VNĐ',
        link:"Conversechuck2allstarfullden.html"
    },
    {
        hinh:"img/sp7.jpg",
        ten:"Giày Adidas stan smith màu trắng xanh",
        gia: '499.000VNĐ',
        link:"single-product.html"
    },
    {
        hinh:"img/sp8.jpg",
        ten:"Giày thể thao Nike Downdhifter Black",
        gia: '899.000VNĐ',
        link:"GiaythethaoNikeDowndhifterBlack.html"
    },
    {
        hinh:"img/sp9.jpg",
        ten:"Giày thể thao Vans Old Skool Retro Classic",
        gia: '540.000VNĐ',
        link:"GiaythethaoVansOldSkoolRetroClassic.html"
    },
    {
        hinh:"img/sp10.jpg",
        ten:"Converse Chuck Taylor All Star Classic",
        gia: '840.000VNĐ',
        link:"ConverseChuckTaylorAllStarClassic.html"
    },
    {
        hinh:"img/sp11.jpg",
        ten:"Adidas Originals Deerupt Runner",
        gia: '440.000VNĐ',
        link:"AdidasOriginalsDeeruptRunner.html"
    },
    {
        hinh:"img/sp12.jpg",
        ten:"Vans Old Skool Full Black",
        gia: '540.000VNĐ',
        link:"VansOldSkoolFullBlack.html"
    },  
    {
        hinh:"img/sp13.jpg",
        ten:"Converse chuck modern lux",
        gia: '1.400.000VNĐ',
        link:"Conversechuckmodernlux.html"
    },  
    {
        hinh:"img/sp14.jpg",
        ten:"Nike Craft Mars Yard 2.0",
        gia:' 1.600.000VNĐ',
        link:"NikeCraftMarsYard2.0.html"
    },  
    
];
 
$(document).ready(function(){   
    var i;
    var nsp = sanpham.length;
    var startitem = nsp-5;
    i = startitem; 
    
    $(".single-product-area").on('load',(function() { 
        page =  $(this).text();
        startitem = 12*page;  
        $("div.product-widget-area div.container div.row:first()").empty();                      
            var dem = 0;
            while(i<nsp){            
                var img = '<a href="'+sanpham[i].link+'"><img src="'+sanpham[i].hinh+'" alt="" class="product-thumb"></a>';    
                var ten = '<h2><a href="'+sanpham[i].link+'">'+sanpham[i].ten+'</a></h2>';
                var sao = '<div class="product-wid-rating"><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i></div>';
                var gia = '<div class="product-wid-price"><ins>'+sanpham[i].gia+'</ins></div>';
                var xuat = '<div class="single-wid-product">'+img+ten+sao+gia+'</div>';
                $('.product-widget-area > .container > .row > .col-md-4:nth-child(3) > .single-product-widget').append(xuat);           
                i--; ++dem;
                if(dem==3)break;                  
            }
    }));
 
 
    var dem = 0;
    while(i<nsp){            
        var img = '<a href="'+sanpham[i].link+'"><img src="'+sanpham[i].hinh+'" alt="" class="product-thumb"></a>';    
        var ten = '<h2><a href="'+sanpham[i].link+'">'+sanpham[i].ten+'</a></h2>';
        var sao = '<div class="product-wid-rating"><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i></div>';
        var gia = '<div class="product-wid-price"><ins>'+sanpham[i].gia+'</ins></div>';
        var xuat = '<div class="single-wid-product">'+img+ten+sao+gia+'</div>';
        $('.product-widget-area > .container > .row > .col-md-4:nth-child(3) > .single-product-widget').append(xuat);           
        i++; ++dem;
        if(dem==3)break;                  
    }
});