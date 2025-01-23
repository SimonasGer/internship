import axios from "axios"
import { useState, useEffect } from "react"
import { Link } from "react-router-dom"
const Home = () => {
    const [scores, setScores] = useState([])
    const [loading, setLoading] = useState(true)

    useEffect(() => {
        const loadScores = async () => {
            try {
                const res = await axios.get(`http://localhost:5017/score`)
                setScores(res.data)
            } catch (err) {
                console.error(err);
            }
        }
        if(loading){
            setLoading(false)
            loadScores()
        }
    }, [loading])

    return(
        <main className="home">
            <h2>Quiz scores</h2>
            <section>
                <ol>
                    {scores.map((score) => 
                        <li key={score.id}><p>{score.email}</p><p>{score.points}</p><p>{score.createDate.slice(0, 19).replace("T", " ")}</p></li>
                    )}
                </ol>
            </section>
            <Link className="link" to = "/quiz">Take the quiz</Link>
        </main>
    )
}

export default Home