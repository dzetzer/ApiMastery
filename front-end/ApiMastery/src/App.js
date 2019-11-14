import React from "react";
import DisplayApp from "./components/DisplayApp";

const Sidebar = document.querySelector(".sidebar");
const Body = document.querySelector(".body");



function navData()
{
  apiActions.getRequest("https://localhost:44386/api/series", series => {
    Sidebar.innerHTML = <Sidebar sidebarObjects={series}/>
  });
}
function navSelect()
{
  const navItem= document.querySelector(".nav__artists");
  const navObject = event.target.parentElement.querySelector(
    ".update-artist__id"
  ).value;
  artistsButton.addEventListener("click", function(){
      Body.innerHTML = <Body bodyObject={navObject}/>;
  })
}

export default () => (
  <>
    <DisplayApp/>
  </>
);
