import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import Counter from "@/components/Counter.vue";
import FetchData from "@/components/FetchData.vue";

import Contracts from "@/components/UserMenuComponents/Contracts.vue"
import Portraits from "@/components/UserMenuComponents/Portraits.vue"
import Medallions from "@/components/UserMenuComponents/Medallions.vue"
import Texts from "@/components/UserMenuComponents/Texts.vue";


const routes = [
    {
        path: "/",
        name: "Home",
        component: Home,
    },
    {
        path: "/Counter",
        name: "Counter",
        component: Counter,
    },
    {
        path: "/FetchData",
        name: "FetchData",
        component: FetchData,
    },
    {
        path: "/Texts",
        name: "Texts",
        component: Texts,
    },
    {
        path: "/Portraits",
        name: "Portraits",
        component: Portraits,
    },
    {
        path: "/Medallions",
        name: "Medallions",
        component: Medallions,
    },
    {
        path: "/Contracts",
        name: "Contracts",
        component: Contracts
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;