# TestTaskServer
ASP.net MVC WebAPI server

<div>
        <h1>API endpoints:</h1>
        <ul style="font-size:xx-large">
            <li>[GET] /api/bids => Return all bids</li>
            <li>[GET] /api/bids/:BidId => Return bid with BidId</li>
            <li>[POST] /api/bids => Add new bid</li>
            <li>[PUT] /api/bids/:BidId => Alter bid with BidId</li>
            <li>[DELETE] /api/bids/:BidId => Remove bid with BidId</li>
        </ul>
        <h1>Bid entity example:</h1>
        <div  style="font-size:xx-large">
            <pre>
    {
        "BidId": 1,
        "BidDate": "2019-11-30T00:00:00+03:00",
        "BidNumber": "121",
        "OrganizationName": "Freelance",
        "UserName": "Nikolaev V.V.",
        "UserPosition": "Programmer",
        "Email": "valetmail@gmail.com"
    }
        </pre>
        </div>
    </div>
