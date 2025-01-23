import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Header from "../header/Header";
import Home from "../home/Home";
import Quiz from "../quiz/Quiz";
import "./style.scss"
function App() {
  return (
    <div className="App">
      <Router>
        <Header/>
        <Routes>
          <Route element = {<Home/>} path = "/"/>
          <Route element = {<Quiz/>} path = "/quiz"/>
        </Routes>
      </Router>
    </div>
  );
}

export default App;
