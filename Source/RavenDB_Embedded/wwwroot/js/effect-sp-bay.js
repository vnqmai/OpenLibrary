$('document').ready(function() {
	//HIỆU ỨNG SẢN PHẨM BAY VÀO GIỎ HÀNG
	$('.add-to-cart-link, .add_to_cart_button').on('click', function(event) {
		event.preventDefault();
		var parTop;
			var parLeft;
			var selff = $(this);		
							
			if($(this).parent().hasClass('cart')){// trang single product
				parTop = $(this).parent().parent().parent().parent().find('.product-main-img').find('img').offset().top;
				parLeft = $(this).parent().parent().parent().parent().find('.product-main-img').find('img').offset().left;			
			}
			else{ //trang index, shop
				parTop = $(this).parent().parent().offset().top;
				parLeft = $(this).parent().parent().offset().left;			
			}
			
			//thêm hình thu nhỏ
			var txtimgfly = '<img src="'+localStorage.getItem("anhsp")+'" class="img-product-fly">';
			$('.header-area').after(txtimgfly);
			$('.img-product-fly').css({
				top: parTop,
				left: parseInt(parLeft,10) + parseInt($(this).parent().width(),10)-80
			});

			//hiệu ứng bay vào giỏ hàng
			setTimeout(function(){
				$(".img-product-fly").css({// bay
					top: $(".shopping-item").offset().top,
					left: $(".shopping-item").offset().left
				});
				setTimeout(function(){// dừng --> xóa hình thu nhỏ
					$('.img-product-fly').remove();				
				},2000);
			},500);
	});
});
		