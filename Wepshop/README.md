# Blazor clientside webshop using API
#### Using own API from previous project

## Purpose
The assignment was that we should make a SPA using our own API and
create a working webshop.

- [x] Basket in the corner
- [x] Show basket
- [ ] Add new item to store
- [ ] Edit item in store
- [ ] Delete item in store
- [x] Show products on front page
- [x] Browse products through categories
- [x] See details of products

I decided *not* to implement editing of products in the SPA, given
that in a real production environment, you would **never** edit your
products in your client front-end. This would be handled in it's own
back-end (or by a separate web application)

There is however built in CRUD functions
- You can create new orders
- You can update customer information (name, address, e-mail etc.)

## Application requirements
- Working API (see previous project)
- Remember to check the goddamn IP of the API and edit it in
- Program.cs (marked with a comment)
- Some sort of computer to run the executable

## Special comments
This application have been made with NO installed libraries, packages etc.

I have made it as a *proof of concept* that you can make a Blazor
SPA without adding anything out of the box. To avoid using
cookies/local storage, the cart is saved in a variable. This however
means that the cart will be emptied on a full reload of the page,
which is not the best way to do it. I got stubborn however and decided
to avoid any extras - even if this resulted in ugly coding.

## Installed libraries
NuGet packs: *none*

JS Libraries: *none*