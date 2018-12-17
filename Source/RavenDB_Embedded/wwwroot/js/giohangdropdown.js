$(document).ready(function() {
	var mang = [];
	var chitiet;
	//bắt sự kiện click nút add to cart
	$('.add-to-cart-link, .add_to_cart_button').on('click', function(event) {
		event.preventDefault();

		var hinh; var ten; var gia; var soluong; var tongchitiet;	

		//lấy dữ sản phẩm đang chọn		
		if($(this).parent().hasClass('cart')){ //trang singleproduct
			ten = $(this).parent().parent().find('.product-name').text();
			gia = $(this).parent().parent().find('.product-inner-price').find('ins').text();
			soluong= $(this).parent().find('.qty').val();
			hinh = $(this).parent().parent().parent().parent().find('.product-main-img').find('img').attr('src');
			tongchitiet = parseInt(loaibodaucham(loaibodonvi(gia)),10)*parseInt(soluong,10);			
		}
		else{//trang index, cart	
			hinh = $(this).parent().parent().find('img').attr('src');
			ten = $(this).parent().parent().parent().find('h2').find('a').text();
			gia = $(this).parent().parent().parent().find('.product-carousel-price').find('ins').text();		
			soluong = 1;
			tongchitiet = parseInt(loaibodaucham(loaibodonvi(gia)),10)*parseInt(soluong,10);				
		}
		chitiet = '{'+hinh+','+ten+','+gia+','+soluong+','+tongchitiet+'VNĐ}';
	});
});