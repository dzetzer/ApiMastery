import React from "react";
import apiActions from "/api/ApiActions.js"

function navData()
{
  apiActions.getRequest("https://localhost:44386/api/series", series);
  return series;
}