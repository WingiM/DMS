import React from "react";
import {Navigate} from "react-router-dom";

class ErrorBoundary extends React.Component {
    constructor(props) {
        super(props);
        this.state = { hasError: false };
    }

    static getDerivedStateFromError(error) {
        // Update state so the next render will show the fallback UI.
        return { hasError: true };
    }

    componentDidCatch(error, info) {
        // Example "componentStack":
        //   in ComponentThatThrows (created by App)
        //   in ErrorBoundary (created by App)
        //   in div (created by App)
        //   in App
        this.logComponentStackToMyService(info.componentStack);
    }
    
    logComponentStackToMyService(mes) {
        console.log(mes)
    }

    render() {
        if (this.state.hasError) {
            localStorage.removeItem("token")
            return <Navigate to={"/login"}/>;
        } else {
            return this.props.children;
            
        }
    }
}

export default ErrorBoundary