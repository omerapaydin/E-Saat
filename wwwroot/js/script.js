const products = [
    { id: 1, name: "Aura Noise-Cancelling", cat: "Ses Sistemleri", price: "4.200", img: "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?q=80&w=1000" },
    { id: 2, name: "Minimalist Watch v2", cat: "Aksesuar", price: "2.850", img: "https://images.unsplash.com/photo-1523275335684-37898b6baf30?q=80&w=1000" },
    { id: 3, name: "Smart Pods Pro", cat: "Mobil", price: "1.900", img: "https://images.unsplash.com/photo-1588333390673-44541cd8226b?q=80&w=1000" },
    { id: 4, name: "Ergonomic Mouse", cat: "Ofis", price: "850", img: "https://images.unsplash.com/photo-1527864550417-7fd91fc51a46?q=80&w=1000" }
];

const renderProducts = () => {
    const list = document.getElementById('product-list');
    list.innerHTML = products.map(p => `
        <div class="col-md-3">
            <div class="product-card h-100">
                <div class="img-container">
                    <img src="${p.img}" class="img-fluid w-100 h-100 object-fit-cover" alt="${p.name}">
                    <button class="btn btn-dark rounded-pill px-4 add-to-cart-btn shadow" onclick="updateCart()">
                        Sepete Ekle
                    </button>
                </div>
                <div class="mt-3">
                    <small class="text-uppercase text-muted fw-bold" style="font-size: 10px;">${p.cat}</small>
                    <h5 class="fw-bold mb-1">${p.name}</h5>
                    <p class="fw-semibold text-secondary">₺${p.price}</p>
                </div>
            </div>
        </div>
    `).join('');
}

let count = 0;
function updateCart() {
    count++;
    document.getElementById('cart-count').innerText = count;
}




window.addEventListener('scroll', () => {
    const scroll = window.scrollY;
    const watch = document.querySelector('.floating-watch');
    if(watch) {
        watch.style.transform = `translateY(${scroll * 0.1}px) rotate(${scroll * 0.02}deg)`;
    }
});

window.addEventListener("load", () => {

    renderProducts();

    const cards = document.querySelectorAll('.product-card');

    const observer = new IntersectionObserver(entries => {

        entries.forEach(entry => {

            if(entry.isIntersecting){
                entry.target.classList.add('show-card');
            }

        });

    },{
        threshold:0.15
    });

    cards.forEach(card => {
        observer.observe(card);
    });

});