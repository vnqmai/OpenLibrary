$(document).ready(function() {
	var mangrecent = [];
	var chitiet;
	function layhinh(chuoi){
		var i = 0; var n = chuoi.length;
		var dphay = 0;		
		var hinh = "";
		for(i=0;i<n;++i){
			if(chuoi[i] == "{"||chuoi[i] == "}")continue;
			if(chuoi[i] == ","){
				++dphay;
				++i;
			}
			if(dphay==0)hinh+=chuoi[i];
		}	
		return hinh;
	}
	function dinhdangtenfilehtmlSingleProduct(chuoi){
		var chuoikq = chuoi.replace(/à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ/g,"a");
		chuoikq = chuoikq.replace(/ó|ò|ỏ|ọ|õ|ô|ồ|ố|ổ|ỗ|ộ|ơ|ờ|ớ|ở|ỡ|ợ/g,"o");
		chuoikq = chuoikq.replace(/ù|ú|ủ|ũ|ụ|ư|ừ|ứ|ử|ữ|ự/g,"u");
		chuoikq = chuoikq.replace(/ì|í|ỉ|ĩ|ị/g,"i");
		chuoikq = chuoikq.replace(/è|é|ẻ|ẽ|ẹ|ê|ề|ế|ể|ễ|ệ/g,"e");
		chuoikq = chuoikq.replace(/ /g,"");
		return chuoikq;
		
	}
	function layten(chuoi){
		var i = 0; var n = chuoi.length;
		var dphay = 0;		
		var ten = "";
		for(i=0;i<n;++i){
			if(chuoi[i] == "{"||chuoi[i] == "}")continue;
			if(chuoi[i] == ","){
				++dphay;
				++i;
			}
			if(dphay==1)ten+=chuoi[i];
		}	
		return ten;
	}
	function loaibodonvi(chuoi){
		return chuoi.replace(" VNĐ","");
	}
	function loaibodaucham(chuoi){
		var chuoikq = "";
		var i =  0;
		var n = chuoi.length;
		for(i=0;i<n;++i){
			if(chuoi[i]==".")continue;
			else chuoikq+=chuoi[i];
		}
		return chuoikq;
	}	
	function laygia(chuoi){
		var i = 0; var n = chuoi.length;
		var dphay = 0;		
		var gia = "";
		for(i=0;i<n;++i){
			if(chuoi[i] == "{"||chuoi[i] == "}")continue;
			if(chuoi[i] == ","){
				++dphay;
				++i;
			}
			if(dphay==2)gia+=chuoi[i];
		}	
		gia=loaibodaucham(gia);
		gia=loaibodonvi(gia);
		return gia;
	}
	function dinhdangtiente(chuoi){
		return chuoi.toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1.")+"VNĐ";
	}
	$('.add-to-cart-link, .add_to_cart_button').on('click', function(event) {
		event.preventDefault();
		//thêm chitiet vào mảng recent click
		chitiet = localStorage.getItem("chitietsp");
		mangrecent.push(chitiet);
		localStorage.setItem("mangrecentview",mangrecent);
		localStorage.setItem("nmangrecentview",mangrecent.length);
	});
	//bắt sự kiện see details click--> thêm sp vào mảng mangrecent
	$('.view-details-link').click(function(event) {
		var hinh=""; var ten=""; var gia=""; var soluong=""; var tongchitiet="";
		hinh = $(this).parent().parent().find('img').attr('src');
		ten = $(this).parent().parent().parent().find('h2').find('a').text();
		gia = $(this).parent().parent().parent().find('.product-carousel-price').find('ins').text();		
		soluong = 1;
		tongchitiet = parseInt(loaibodaucham(loaibodonvi(gia)),10)*parseInt(soluong,10);	
		chitiet = '{'+hinh+','+ten+','+gia+','+soluong+','+tongchitiet+'VNĐ}';	
		mangrecent.push(chitiet);		
		localStorage.setItem("mangrecentview",mangrecent);
		localStorage.setItem("nmangrecentview",mangrecent.length);		
	});

	//load 3 sp cho recently view trang index
	var b = localStorage.getItem("mangrecentview");
	var nb = localStorage.getItem("nmangrecentview");
	var r = 0; var s = 0; var vttt=0;
		while(r<nb){
			var spp = ""; 
			for(s=vttt;s<b.length;++s){
				if(b[s]=="}"){
					spp+="}"	
					vttt = s+2;			
					break;
				}						
				spp+=b[s];					
			}			
			mangrecent.push(spp);		
			++r;
		}
	
	if(b.length!=null){				
		s=0; var t = "";
		for(r=nb-1;r>=0;--r){
			if($('.product-widget-area > .container > .row > .col-md-4:nth-child(2) > .single-product-widget > .single-wid-product').length==3)break;
			else{
				var img = '<a href="single-product.html"><img src="'+layhinh(mangrecent[r])+'" alt="" class="product-thumb"></a>';	
				var href = dinhdangtenfilehtmlSingleProduct(layten(mangrecent[r]));
				if(href == 'GiayAdidasstansmithmautrangxanh')href="single-product";				
				var name = '<h2><a href="'+href+'.html">'+layten(mangrecent[r])+'</a></h2>';
				var star = '<div class="product-wid-rating"><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i></div>';
				var price = '<div class="product-wid-price"><ins>'+dinhdangtiente(laygia(mangrecent[r]))+'</ins></div>';
				var txtrecent = '<div class="single-wid-product">'+img+name+star+price+'</div>';
				if(t!=txtrecent)$('.product-widget-area > .container > .row > .col-md-4:nth-child(2) > .single-product-widget').append(txtrecent);				
				t=txtrecent;	
			}							
		}
	}
});