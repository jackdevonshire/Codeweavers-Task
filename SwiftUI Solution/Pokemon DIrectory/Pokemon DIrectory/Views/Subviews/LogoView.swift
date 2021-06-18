//
//  LogoView.swift
//  Pokemon DIrectory
//
//  Created by Jack Devonshire on 30/05/2021.
//

import SwiftUI

struct LogoView: View {
    var body: some View {
        VStack {
            HStack {
                Image("Pokeball")
                    .resizable()
                    .frame(width: 100, height: 100, alignment: /*@START_MENU_TOKEN@*/.center/*@END_MENU_TOKEN@*/)
                Text("Pokemon Directory")
                    .font(.system(size: 30, weight: .medium, design: .default))
            }
        }
    }
}

struct LogoView_Previews: PreviewProvider {
    static var previews: some View {
        LogoView()
    }
}
