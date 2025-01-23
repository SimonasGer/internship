import { Link } from "react-router-dom"
import Questions from "./Questions"
import { useState, useEffect } from "react"
import axios from "axios"
const Quiz = () => {
    const [score, setScore] = useState([])
    const [email, setEmail] = useState("")
    const [position, setPosition] = useState(0)
    const handleSubmit = async (e) => {
        e.preventDefault()
        try {
            const res = await axios.post(`http://localhost:5017/score`, {
                email: email,
                answers: score,
                createDate: new Date()
            })
            console.log(res)
        } catch (err) {
            console.error(err);
        }
    }

    useEffect(() => {
        window.onscroll = () => {
            setPosition(window.scrollY + (window.innerHeight * (position/document.body.scrollHeight)))
        }
    }, [position])

    return(
        <form className="quiz" onSubmit={handleSubmit}>
            <h2>Quiz</h2>
            <Link className="link" to = "/">Quit and go back to results</Link>
            <div className="progress">
                <div style={{width: `${(position/document.body.scrollHeight) * 100}%`}} className="bar"></div>
            </div>
            <Questions setEmail = {setEmail} score = {score} setScore = {setScore}/>
            <button href = "/" type="submit">Finish</button>
        </form>
    )
}

export default Quiz