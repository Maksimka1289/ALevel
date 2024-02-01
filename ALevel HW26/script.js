document.addEventListener('DOMContentLoaded', function () {
    const dataContainer = document.getElementById('data-container');
  
    function fetchData(page) {
      const apiUrl = `https://reqres.in/api/users?page=${page}`;
  
      fetch(apiUrl)
        .then(response => response.json())
        .then(data => {
          dataContainer.innerHTML = '';

          data.data.forEach(user => {
            const card = document.createElement('div');
            card.className = 'col';
            card.innerHTML = `
              <div class="card">
                <div class="card-body">
                  <h5 class="card-title">${user.first_name} ${user.last_name}</h5>
                  <p class="card-text">${user.email}</p>
                </div>
              </div>
            `;
            dataContainer.appendChild(card);
          });
        })
        .catch(error => console.error('Error fetching data:', error));
    }
  
    document.getElementById('buttonPage1').addEventListener('click', function () {
      fetchData(1);
    });
  
    document.getElementById('buttonPage2').addEventListener('click', function () {
      fetchData(2);
    });
  
    document.getElementById('buttonPage3').addEventListener('click', function () {
      fetchData(3);
    });
  });
  