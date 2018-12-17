$("document").ready(function() {															
	var mang = []; var a; var chitiet;
	
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
	function laysoluong(chuoi){
		var i = 0; var n = chuoi.length;
		var dphay = 0;		
		var soluong = "";
		for(i=0;i<n;++i){
			if(chuoi[i] == "{"||chuoi[i] == "}")continue;
			if(chuoi[i] == ","){
				++dphay;
				++i;
			}
			if(dphay==3)soluong+=chuoi[i];
		}	
		return soluong;
	}
	function laygiaxsoluong(chuoi){
		var i = 0; var n = chuoi.length;
		var dphay = 0;		
		var gxsl = "";
		for(i=0;i<n;++i){
			if(chuoi[i] == "{"||chuoi[i] == "}")continue;
			if(chuoi[i] == ","){
				++dphay;
				++i;
			}
			if(dphay==4)gxsl+=chuoi[i];
		}	
		gxsl=loaibodaucham(gxsl);
		gxsl=loaibodonvi(gxsl);
		return gxsl;
	}	
	function isInArray(chuoi){
		var i = 0; var n = mang.length;		
		for(i=0;i<n;++i){
			if(layhinh(mang[i])==layhinh(chuoi)) return i;
		}
		return -1;
	}
	function loaidauphay(chuoi){
		var i = 0; var n = chuoi.length;
		var chuoikq = "";
		for(i=0;i<n;++i){
			if(chuoi[i]==","&&chuoi[i+1]=="{")continue;			
			else chuoikq+=chuoi[i];
		}
		return chuoikq;
	}	
	function xoaphantutrong(mangg){
		var i = 0; var n = mangg.length;
		var vt = -1;
		for(i=0;i<n;++i){
			if(mangg[i]==""){
				vt = i;
				break;
			}

		}
		if(vt!=-1) mangg = mangg.splice(i,1);
	}
	function tinhtongcart(){
		//cart total			
		var tong = 0;
		var m = 0;
		for(m = 0;m<mang.length;++m){
			tong+=parseInt(laygiaxsoluong(mang[m]),10);
		}
		tong = dinhdangtiente(tong);
		localStorage.setItem("tongcart",tong);

		$('.shopping-item').find('.items').find('.total-gio-hang').find('.tong-gio-hang').find('span').text(tong);

		//show tongcart và ngiohang lên cart bên góc phải 
		$(".shopping-item").find('.cart-amunt').text(localStorage.getItem("tongcart"));		

		//bảng total nhỏ trang cart
		$('.cart-subtotal').find('.amount').text(tong);
		$('.order-total').find('.amount').text(tong);

	}
	function tinhtongsoluong(){
		var tongsl = 0;
		var i = 0;
		var n = mang.length;
		for(i=0;i<n;++i){
			tongsl+=parseInt(laysoluong(mang[i]),10);
		}
		localStorage.setItem("tongsoluong",tongsl);
		$(".shopping-item").find('.product-count').text(localStorage.getItem("tongsoluong"));
	}
	function loaibodonvi(chuoi){
		var chuoikq = chuoi.replace(" VNĐ","");
		chuoikq = chuoi.replace("VNĐ","");
		return chuoikq;
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
	function dinhdangtiente(chuoi){
		return chuoi.toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1.")+"VNĐ";
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
	function themvaogiohangdropdown(hi,te,gi,sol,gixsol){
		//add vào giỏ hàng shopping-item			
		var taghinh = '<div class="hinhsp-gio-hang-div"><img src="'+hi+'" class="img-hinhsp-gio-hang"></div>';
		var tagten = '<div class="thongtinsp-gio-hang-div"><a href="" class="a-tensp-gio-hang">'+te+'</a><br>';
		var taggia= '<a class="a-giasp-gio-hang">'+dinhdangtiente(gi)+'</a><br>';
		var tagsoluong = '<a>Số lượng: </a><input type="number" class="inp-soluongsp-gio-hang" value="'+sol+'" readonly>';
		var taggiaxsoluong = ' <a class="a-tongchitietsp-gio-hang">Giá x Số lượng: <span>'+dinhdangtiente(gixsol)+'</span></a><br>';
		var tagx = '<a class="x-btn" href="">x</a><br></div><hr>';
		var tag = '<div class="item">'+taghinh+tagten+taggia+tagsoluong+taggiaxsoluong+tagx+'</div>';
		$('.shopping-item').find('.items').find('.total-gio-hang').before(tag);							
	}
	function capnhatgiohangdropdown(hi,te,gi,slmoi,gixslmoi,vTri){//nếu chọn trùng sp có sẵn trong giỏ		
		$('.shopping-item').find('.items').find('.item:nth-child('+(vTri+1)+')').remove();		
		themvaogiohangdropdown(hi,te,gi,slmoi,gixslmoi);
		tinhtongcart();
		tinhtongsoluong();		
	}		

	//-----------------------------TRANG CART VS GIỎ HÀNG DROPDOWN-----------------------------------------
	//bắt sự kiện click nút add to cart
	$('.add-to-cart-link, .add_to_cart_button').on('click',(function(event) {
		var hinh; var ten; var gia; var soluong; var tongchitiet;		

		//lấy dữ sản phẩm đang chọn		
		if($(this).parent().hasClass('cart')){ //trang singleproduct
			ten = $(this).parent().parent().find('.product-inner-price').find('h2').text();			
			gia = $(this).parent().parent().find('.product-inner-price').find('ins').text();
			soluong= $(this).parent().find('.qty').val();
			hinh = $(this).parent().parent().parent().parent().find('.product-main-img').find('img').attr('src');
			tongchitiet = parseInt(loaibodaucham(loaibodonvi(gia)),10)*parseInt(soluong,10);			
		}
		else if($(this).parent().parent().parent().find('h2').text()=="Bạn có thể quan tâm đến"){ // trang cart You may interested
			ten = $(this).parent().find('h3').text();
			gia = $(this).parent().find('.amount').text();
			soluong = 1;
			hinh = $(this).parent().find('img').attr('src');
			tongchitiet = parseInt(loaibodaucham(loaibodonvi(gia)),10)*parseInt(soluong,10);									
		}
		else{//trang index, cart	
			hinh = $(this).parent().parent().find('img').attr('src');
			ten = $(this).parent().parent().parent().find('h2').find('a').text();
			gia = $(this).parent().parent().parent().find('.product-carousel-price').find('ins').text();		
			soluong = 1;
			tongchitiet = parseInt(loaibodaucham(loaibodonvi(gia)),10)*parseInt(soluong,10);				
		}	

		//thêm vào mảng giỏ hàng
		chitiet = '{'+hinh+','+ten+','+gia+','+soluong+','+tongchitiet+'}';				
		if(isInArray(chitiet)==-1){			
			mang.push(chitiet);	
			themvaogiohangdropdown(hinh,ten,loaibodonvi(loaibodaucham(gia)),soluong,tongchitiet);											
		}	
		else{						
			//lấy ra chi tiết trùng
			var vt = isInArray(chitiet);
			hinh=""; ten=""; gia=""; soluong=""; tongchitiet="";
			var nmangtrung = mang[vt].length;
			var i =0; var dphay = 0;
			hinh=layhinh(mang[vt]);
			ten = layten(mang[vt]);
			gia = laygia(mang[vt]);
			soluong = laysoluong(mang[vt]);			

			//tính số lượng mới, giá x số lượng mới
			var soluongmoi;
			//sl trang single product			
			if($(this).parent().hasClass('cart')) {
				soluongmoi = parseInt(soluong,10) + parseInt($(this).parent().find('.qty').val(),10); 
			}
			//sl trang cart
			else soluongmoi = parseInt(soluong,10)+1;
			
			tongchitiet = parseInt(gia,10)*soluongmoi;
			mang[vt]='{'+hinh+','+ten+','+gia+','+soluongmoi+','+dinhdangtiente(tongchitiet)+'}';

			//cập nhật ngay giỏ hàng dropdown				
			capnhatgiohangdropdown(hinh,ten,gia,soluongmoi,tongchitiet,vt);						
		}														
		if($(this).parent().parent().parent().find('h2').text()=="Bạn có thể quan tâm đến"){//trang cart YOU MAY INTERESTED...
				location.href = "cart.html"; 
		}
		xoaphantutrong(mang);//xóa phần tử trống ""
		
		//cart total			
		tinhtongcart();
		tinhtongsoluong();		

		localStorage.setItem("giohang",mang);
		localStorage.setItem("ngiohang",mang.length);							
		localStorage.setItem("anhsp",hinh);	//lưu hình cho file effect-sp-bay.js	
		localStorage.setItem("chitietsp",chitiet);	//lưu chitiet cho file loadRecentlyViewIndex.js
						
	}));				
	a = localStorage.getItem("giohang"); var na = a.length;

	if(na!=null){

		//load lại dữ liệu khi load lại trang
		var ngiohang = localStorage.getItem("ngiohang");
		var i = 0;
		var k = 0; var vtt = 0;
		xoaphantutrong(mang);
		while(k<ngiohang){
			var sp = ""; 
			for(i=vtt;i<na;++i){
				if(a[i]=="}"){
					sp+="}"	
					vtt = i+2;			
					break;
				}						
				sp+=a[i];					
			}			
			if(isInArray(sp)==-1&&sp!="") mang.push(sp);		
			++k;
		}						

		//tách thành phần sản phẩm từng dòng cho giỏ hàng						
		var l = 0;	
		k = 0;
		while(k<mang.length){

			//lấy thông tin
			var h = ""; var t = ""; var g = ""; var sl = ""; var gxsl = "";
			var dphay = 0;
			var nsp = mang[k].length;
			mang[k]=loaidauphay(mang[k]);
			h= layhinh(mang[k]);
			t=layten(mang[k]);
			g=laygia(mang[k]);
			sl=laysoluong(mang[k]);			
			gxsl+= parseInt(g,10)*parseInt(sl,10);

			// add vào bảng cart trang cart			
			var txtbegin = '<tr class="cart_item"><td class="product-remove"><a title="Remove this item" class="remove" href="#">×</a></td>';
			var txthinh = '<td class="product-thumbnail"><a href="single-product.html"><img width="145" height="145" alt="poster_1_up" class="shop_thumbnail" src="'+h+'"></a></td>';
			var txtten = '<td class="product-name"><a href="single-product.html">'+t+'</a></td>';
			var txtgia = '<td class="product-price"><span class="amount">'+dinhdangtiente(g)+'</span></td>';
			var txtsoluong = '<td class="product-quantity"><div class="quantity buttons_added"><input type="button" class="minus" value="-"><input type="number" size="4" class="input-text qty text" title="Qty" value="'+sl+'" min="0" step="1"  readonly><input type="button" class="plus" value="+"></div></td>';
			var txtgiaxsoluong = '<td class="product-subtotal"><span class="amount">'+dinhdangtiente(gxsl)+'</span></td>';
			var txtend= '</tr>';
			$('.woocommerce').find('.action-tr').before(txtbegin+txthinh+txtten+txtgia+txtsoluong+txtgiaxsoluong+txtend);

			//cart total			
			tinhtongcart();
			tinhtongsoluong();

			//add vào giỏ hàng dropdown			
			themvaogiohangdropdown(h,t,g,sl,gxsl);			

			++k;
									
		}	
		//--------------------------------------------------------------------------------------------------------

		//-----------------------------------------------TRANG CART-----------------------------------------------
		//bắt sự kiện + - button onclick

			var index;// vị trí sản phẩm onclick trong mảng	

			$('.woocommerce').find('input.minus').click(function(event) {//nút -
				index = $(this).parent().parent().parent().index();

				var hinh = $(this).parent().parent().parent().find('.product-thumbnail').find('a').find('img').attr('src');
				var ten = $(this).parent().parent().parent().find('.product-name').find('a').text();
				var gia = $(this).parent().parent().parent().find('.product-price').find('span').text();
				var soluong = parseInt($(this).parent().find('input:nth-child(2)').val(),10)-1;
				var tongchitiet = parseInt(loaibodaucham(loaibodonvi(gia)),10)*soluong;				
				if($('.woocommerce').find('input:nth-child(2)').val()>=2){
					//cập nhật dữ liệu mảng
					mang[index] = "{"+hinh+","+ten+","+gia+","+soluong+","+dinhdangtiente(tongchitiet)+"}";				

					//cập nhật dữ liệu giao diện
					$(this).parent().find('input:nth-child(2)').val(soluong);
					$(this).parent().parent().parent().find('.product-subtotal').find('span').text(dinhdangtiente(tongchitiet));
								
					//cập nhật cart total
					tinhtongcart();					
					tinhtongsoluong();
				}
				
			});					

			$('.woocommerce').find('input.plus').click(function(event) {//nút +
				index = $(this).parent().parent().parent().index();

				var hinh = $(this).parent().parent().parent().find('.product-thumbnail').find('a').find('img').attr('src');
				var ten = $(this).parent().parent().parent().find('.product-name').find('a').text();
				var gia = $(this).parent().parent().parent().find('.product-price').find('span').text();
				var soluong = parseInt($(this).parent().find('input:nth-child(2)').val(),10)+1;
				var tongchitiet = parseInt(loaibodaucham(loaibodonvi(gia)),10)*soluong;

				//cập nhật mảng
				mang[index] = "{"+hinh+","+ten+","+gia+","+soluong+","+dinhdangtiente(tongchitiet)+"}";
				
				//cập nhật dữ liệu giao diện
				$(this).parent().find('input:nth-child(2)').val(soluong);
				$(this).parent().parent().parent().find('.product-subtotal').find('span').text(dinhdangtiente(tongchitiet));

				//cập nhật cart total
				tinhtongcart();
				tinhtongsoluong();
				
			});	
			//set readonly cho input so luong
			//$('.woocommerce').find('input:nth-child(2)').prop('readonly',true);
			
			//bắt sự kiện update cart onclick
			$('.actions').find('input.up-btn').click(function(event) {				
				localStorage.setItem("giohang",mang);				
				localStorage.setItem("ngiohang",mang.length);

				//cart total			
				tinhtongcart();	
				tinhtongsoluong();		

				alert("Cập nhật thành công!");	
			});

			//bắt sự kiện xóa dòng sản phẩm trong bảng cart
			var removeindex;
			$('a.remove').click(function(event) {
				removeindex = $(this).parent().parent().index();
				//cập nhật mảng			
				mang.splice(removeindex,1);
				//cập nhật giao diện bảng cart
				$(this).parent().parent().parent().children().slice(removeindex,removeindex+1).detach();
				//cập nhật cart total
				tinhtongcart();	
				tinhtongsoluong();						
			});

			//bắt sự kiện proceed to checkout
			$('.actions').find('.btn-pro').click(function(event){								
				 window.location.href = "checkout.html";
			});			

			//phiếu mua hàng
			$('.coupon-btn').click(function(event) {
				var gt = $('.coupon-code').val();
				if(gt==null)alert("Vui lòng nhập mã");				
				gt = gt.replace("%","");
				gt = gt.replace("-","");
				var r = 0; var tong = 0;
				for(r = 0; r<mang.length;++r){
					var hinh = layhinh(mang[r]);
					var ten = layten(mang[r]);
					var gia = parseInt(laygia(mang[r]),10)-(parseInt(laygia(mang[r]),10)*gt/100);
					var soluong = laysoluong(mang[r]);
					var tongchitiet = gia*parseInt(soluong);
					chitiet = "{"+hinh+","+ten+","+gia+","+soluong+","+tongchitiet+"}";
					mang[r]=chitiet;
					location.href = location.href;

				}					
				tinhtongcart();
				localStorage.setItem("giohang",mang);
				alert("Đã áp dụng mã phiếu mua hàng!");																
			});
			//------------------------------------------------------------------------------------------
			

			//------------------------------------GIỎ HÀNG DROP DOWN------------------------------------									

			//bắt sự kiện number input onchange cho giỏ hàng dropdown
			$('.inp-soluongsp-gio-hang').prop('readonly',true);
			
			//bắt sự kiện xóa dòng sản phẩm trong giỏ hàng dropdown
			$('.x-btn').click(function(event) {
				removeindex = $(this).parent().parent().index();				
				//cập nhật mảng			
				mang.splice(removeindex,1);
				localStorage.setItem('giohang',mang);
				//cập nhật giao diện giỏ hàng				
				$(this).parent().parent().parent().children('.item').slice(removeindex, removeindex+1).detach();
				//cập nhật cart total				
				tinhtongcart();	
				tinhtongsoluong();					
			});
			//------------------------------------------------------------------------------------------			
	}					
});