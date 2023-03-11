import { AnimatePresence } from "framer-motion";
import Home from "./pages/Home";

function App() {
  return (
    <AnimatePresence exitBeforeEnter>
      <Home />
    </AnimatePresence>
  );
}

export default App;
