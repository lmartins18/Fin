import SideBar from "../components/SideBar";
import Example from "../components/PieChart";

function Home() {
  return (
    <div className="h-full w-full flex bg-gradient-to-b from-sky-300 via-sky-200 to-sky-300">
      <SideBar />
      <div className="flex flex-1">
        <div className="flex flex-1 flex-col">
          <div className="flex flex-1 bg-white m-12 mb-6 rounded-xl">
            <Example />
          </div>
          <div id="buttons" className="gap-3 mb-6 flex justify-center">
            <span className="relative flex h-4 w-4">
              <span className=" absolute inline-flex h-full w-full rounded-full bg-white opacity-75"></span>
              <span className="relative inline-flex rounded-full h-4 w-4 bg-white"></span>
            </span>
            <span className="relative flex h-4 w-4">
              <span className=" absolute inline-flex h-full w-full rounded-full bg-white opacity-75"></span>
              <span className="relative inline-flex rounded-full h-4 w-4 bg-white"></span>
            </span>
            <span className="relative flex h-4 w-4">
              <span className=" absolute inline-flex h-full w-full rounded-full bg-white opacity-75"></span>
              <span className="relative inline-flex rounded-full h-4 w-4 bg-white"></span>
            </span>
          </div>
        </div>
        <div className="flex flex-3 flex-col gap-3 bg-gradient-to-b from-sky-500 to-sky-800 rounded-r-lg p-3 ring-4  ring-sky-300">
          <div id="icon-panel" className="text-sky-900/50 text-4xl flex gap-1">
            <p className="my-2">Fin.</p>
          </div>
          <div
            id="accounts-panel"
            className="flex flex-col flex-1 text-sky-200 gap-4"
          >
            <p className="text-2xl">Accounts.</p>
            <div
              id="accountas"
              className="bg-sky-800 rounded-xl flex flex-col gap-2 py-3 px-1"
            ></div>
          </div>
          <div id="config-panel">
            <div id="user-panel" className="flex">
              <div id="side-panel" className="flex flex-col flex-1 m-3 my-auto">
                <p className="text-sky-200 text-sm">Shabbaf Ranks</p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Home;
