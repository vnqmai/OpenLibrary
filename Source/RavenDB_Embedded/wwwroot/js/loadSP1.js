var sanpham = [
   
    
    {
        hinh:"img/sp8.jpg",
        ten:"Sách luyện chữ đẹp"
    },
    {
        hinh:"img/sp9.jpg",
        ten:"Sách toán lớp 9",

    },
    {
        hinh:"img/sp10.jpg",
        ten:"Sách bài tập toán 9",
        
    },
    {
        hinh:"img/sp11.jpg",
        ten:"Sách văn học dân gian Việt Nam",
       
    },
    {
        hinh:"img/sp12.jpg",
        ten:"Sách tin học cơ bản",
        
    },  
    {
        hinh:"img/sp13.jpg",
        ten:"Sách KHVT",
      
    },  
    {
        hinh:"img/sp14.jpg",
        ten:"Truyện tranh"
        
    },  
    
];

$(document).ready(function(){	
	var i;
	var nsp = sanpham.length;

	var startitem = 0;

	var npage = Math.ceil(nsp/3); var demtrang = npage; var j =0; var page=1; 
	for(j=0;j<npage;++j){
		var trangli='<li><a href="#">'+demtrang+'</a></li>';
		$(".pagination li:nth-child(1)").after(trangli);		
		--demtrang;
	}	
	i = startitem;	
	$(".pagination li").click(function(event) {	
		page = 	$(this).text();
		startitem = (3*(page-1));	
		i = startitem;							
		$("div.single-product-area div.container div.row:first()").empty();	
		$("div.single-product-area div.container").after('<div class="row"></div>');
			var dem = 0;
			while(i<nsp){			
				var imgtext = "<div class='product-upper'><img src='"+sanpham[i].hinh+"' alt='' class = 'imgshoppage'></div>";
				var tentext = "<h2><a href=''>"+sanpham[i].ten+"</a></h2>";
			
				var gridrow='<div class="col-md-3 col-sm-6"><div class="single-shop-product">'+imgtext+tentext+'</div></div>';
				$("div.single-product-area > div.container div.row:first()").append(gridrow);			
				++i; ++dem;
				if(dem==3)break;					
		}
	});



	
	var dem = 0;
		while(i<nsp){			
			var imgtext = "<div class='product-upper'><img src='"+sanpham[i].hinh+"' alt='' class = 'imgshoppage'></div>";
			var tentext = "<h2><a href='"+dinhdangtenfilehtmlSingleProduct(sanpham[i].ten)+".html'>"+sanpham[i].ten+"</a></h2>";
			
			var gridrow='<div class="col-md-3 col-sm-6"><div class="single-shop-product">'+imgtext+tentext+'</div></div>';
			$("div.single-product-area > div.container div.row:first()").append(gridrow);			
			++i; ++dem;
			if(dem==3)break;					
		}
			
	function dinhdangtenfilehtmlSingleProduct(chuoi){
        var chuoikq = chuoi.replace(/à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ/g,"a");
        chuoikq = chuoikq.replace(/ó|ò|ỏ|ọ|õ|ô|ồ|ố|ổ|ỗ|ộ|ơ|ờ|ớ|ở|ỡ|ợ/g,"o");
        chuoikq = chuoikq.replace(/ù|ú|ủ|ũ|ụ|ư|ừ|ứ|ử|ữ|ự/g,"u");
        chuoikq = chuoikq.replace(/ì|í|ỉ|ĩ|ị/g,"i");
        chuoikq = chuoikq.replace(/è|é|ẻ|ẽ|ẹ|ê|ề|ế|ể|ễ|ệ/g,"e");
        chuoikq = chuoikq.replace(/đ/g,"d");
        chuoikq = chuoikq.replace(/ /g,"");
        return chuoikq;        
    }
});