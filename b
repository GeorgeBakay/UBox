[1mdiff --cc .vs/UBox/v16/.suo[m
[1mindex 01a8c5b,16acea1..0000000[m
Binary files differ
[1mdiff --cc UBox/obj/Debug/netcoreapp3.1/UBox.csprojAssemblyReference.cache[m
[1mindex 637d3dd,061662d..0000000[m
Binary files differ
[1mdiff --git a/UBox/wwwroot/css/MyProfileStyle.css b/UBox/wwwroot/css/MyProfileStyle.css[m
[1mindex 5b0d02e..fdf53f5 100644[m
[1m--- a/UBox/wwwroot/css/MyProfileStyle.css[m
[1m+++ b/UBox/wwwroot/css/MyProfileStyle.css[m
[36m@@ -135,8 +135,8 @@[m
     margin: 0 auto;[m
     margin-top:10px;[m
     border-radius:10px;[m
[31m-    width:290px;[m
[31m-    height:290px;[m
[32m+[m[32m    width:300px;[m
[32m+[m[32m    height:300px;[m
     overflow:hidden;[m
     display:flex;[m
     justify-content:center;[m
[36m@@ -144,6 +144,7 @@[m
     align-items:center;[m
 }[m
 .posts_element p {[m
[32m+[m[32m    display:none;[m
     width: 90%;[m
     margin: 0 auto;[m
     white-space: nowrap;[m
[36m@@ -151,7 +152,7 @@[m
     text-overflow: ellipsis;[m
 }[m
 .posts_element_content *{[m
[31m-    max-width:300px;[m
[32m+[m[32m    max-height:300px;[m
 }[m
 @keyframes show_nav {[m
     0%{[m
