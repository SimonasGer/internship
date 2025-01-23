import axios from "axios"
import { useState, useEffect } from "react"
import Radio from "./Radio"
import Select from "./Select"
import Freeform from "./Freeform"
const Questions = (props) => {
    const [questions, setQuestions] = useState([])
    const [loading, setLoading] = useState(true)

    useEffect(() => {
        const loadQuestions = async () => {
            try {
                const res = await axios.get(`http://localhost:5017/questions`)
                setQuestions(res.data)
            } catch (err) {
                console.error(err);
            }
        }
        if(loading){
            setLoading(false)
            loadQuestions()
        }
    }, [loading, props, questions])
    return(
        <section>
            {questions.map((question) => 
                (question.questionType === "Radio" && <Radio score = {props.score} setScore = {props.setScore} get = {props.get} key = {question.id} name = {question.name} id = {question.id}/>) ||
                (question.questionType === "Select" && <Select score = {props.score} setScore = {props.setScore} get = {props.get} key = {question.id} name = {question.name} id = {question.id}/>) ||
                (question.questionType === "Freeform" && <Freeform score = {props.score} setScore = {props.setScore} get = {props.get} key = {question.id} name = {question.name} id = {question.id}/>)
            )}
            <fieldset>
                <legend>Enter your email address</legend>
                <div>
                    <input required type="email" onChange= {(e) => {props.setEmail(e.target.value)}}/>
                </div>
            </fieldset>
        </section>
    )
}

export default Questions