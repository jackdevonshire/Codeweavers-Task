//
//  SearchView.swift
//  Pokemon DIrectory
//
//  Created by Jack Devonshire on 30/05/2021.
//

import SwiftUI

struct SearchView: View {
    @State private var query: String = ""
    
    var body: some View {
        ZStack {
            Color("PokemonYellow")
                .ignoresSafeArea()
            VStack {
                LogoView()
                    .padding(.bottom, 20)
                
                
                HStack {
                    ZStack {
                        Rectangle()
                            .frame(width: 280, height: 50, alignment: /*@START_MENU_TOKEN@*/.center/*@END_MENU_TOKEN@*/)
                            .cornerRadius(20)
                            .foregroundColor(.white)
                        
                        Text("Search for a pokemon...")
                            .font(.system(size: 20, weight: .medium, design: .default))
                            .foregroundColor(.red)
                        
                        TextField("", text: $query)
                            .frame(width: 280, height: 45, alignment: /*@START_MENU_TOKEN@*/.center/*@END_MENU_TOKEN@*/)
                    }
                    .padding(.leading, 10)
                    Spacer()
                    Text("GO")
                    Spacer()
                    
                }
            }
        }
    }
}

struct SearchView_Previews: PreviewProvider {
    static var previews: some View {
        SearchView()
    }
}
