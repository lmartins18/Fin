import React from "react";
import shabba from "./../img/shabba.jpg";
import { GiTakeMyMoney, GiMoneyStack, GiHouse } from "react-icons/gi";
import { MdSettingsSuggest } from "react-icons/md";
import { BsCurrencyBitcoin } from "react-icons/bs";

function SideNavAccount({ icon, title }: { icon: any; title: string }) {
  return (
    <div className="side-nav-account">
      {icon}
      <p>{title}</p>
    </div>
  );
}
function SideBar() {
  return (
    <div className="h-full flex flex-col gap-3 w-1/6 bg-gradient-to-b from-sky-500 to-sky-800 rounded-r-lg p-3 ring-4  ring-sky-300">
      <div id="icon-panel" className="text-sky-900/50 text-4xl flex gap-1">
        <GiTakeMyMoney className="text-5xl" />
        <p className="my-2">Fin.</p>
      </div>
      <div
        id="accounts-panel"
        className="flex flex-col flex-1 text-sky-200 gap-4"
      >
        <p className="text-2xl">Accounts.</p>
        <div id="accountas" className="bg-sky-800 rounded-xl flex flex-col gap-2 py-3 px-1">
          <SideNavAccount icon={<GiMoneyStack className="text-2xl" />} title={"Current Account"} />
          <SideNavAccount icon={<BsCurrencyBitcoin className="text-2xl" />} title={"Crypto Assets"} />
          <SideNavAccount icon={<GiHouse className="text-2xl" />} title={"Real Estate"} />
        </div>
      </div>
      <div id="config-panel">
        <div id="user-panel" className="flex">
          <img
            src={shabba}
            alt="shabba"
            className="rounded-full w-12 h-12 object-cover ring-2 ring-sky-900"
          />
          <div id="side-panel" className="flex flex-col flex-1 m-3 my-auto">
            <p className="text-sky-200 text-sm">Shabba Ranks</p>
          </div>
          <MdSettingsSuggest className="cursor-pointer text-4xl text-slate-900/50 my-auto mr-1" />
        </div>
      </div>
    </div>
  );
}

export default SideBar;
