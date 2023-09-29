import Home from "./components/Home"
import Navbar from "./components/Navbar"
import Products from "./components/Products"
import Supplier from "./components/Supplier"

function App(){
    let component
    switch(window.location.pathname) {
        case "/":
            component = <Home />
            break
        case "/products":
            component = <Products />
            break
        case "/supplier":
            component = <Supplier />
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