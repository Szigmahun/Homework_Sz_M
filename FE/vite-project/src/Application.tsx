import Home from "./components/Home"
import Navbar from "./components/Navbar"
import Products from "./components/Products"

function App(){
    let component
    switch(window.location.pathname) {
        case "/":
            component = <Home />
            break
        case "/products":
            component = <Products />
            break
    }
    return (
        <>
            <Navbar />
            {component}
        </>
    )

    
}

export default App