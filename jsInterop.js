window.DNF = {
    history: {
        back() {
            history.back();
        },
        forward() {
            history.forward();
        },
        go(delta) {
            history.go(delta);
        },
        pushState(data, title, url) {
            history.pushState(data, title, location.pathname + url);
        },
        replaceState(data, title, url) {
            history.replaceState(data, title, location.pathname + url);
        }
    },
    sessionStorage: {
        getItem(key) {
            return sessionStorage.getItem(key);
        },
        setItem(key, value) {
            sessionStorage.setItem(key, value);
        }
    },
    localStorage: {
        getItem(key) {
            return localStorage.getItem(key);
        },
        setItem(key, value) {
            localStorage.setItem(key, value);
        }
    },
    addEventListener(type, callback) {
        addEventListener(type, function (ev) {
            var result = callback.invokeMethodAsync('Callback', type, JSON.stringify(ev));
            if (result === 'false') {
                return false;
            }
        });
    }
};