/* used to resursively build tree
 * result will be a tree usable as a dictionary
 *  
 */

using System;
using System.Collections.Generic;

namespace Scrabblelicious {
    class TreeNode {
        private Char value;
        private Dictionary<Char, TreeNode> children = new Dictionary<Char, TreeNode>();
        private Boolean endofWord;

        public TreeNode(Char v, Boolean e) {
            value = v;
            endofWord = e;
        }

        public Char getValue() {
            return value;
        }

        public Boolean isWord(String s) {
            if ((s.Length == 0)) {
                return endofWord;
            }


            if (this.hasChild(s[0])) {
                return (getChild(s[0]).isWord(s.Remove(0, 1)));
            } else {
                return false;
            }
        }

        public void wordEnds() {
            endofWord = true;
        }


        private Boolean hasChild(Char c) {
            return children.ContainsKey(c);
        }

        private TreeNode getChild(Char c) {
            if (children.ContainsKey(c))
                return children[c];
            else return null;
        }


        public void addWord(String s, TreeNode t) {
            if (s.Length == 0) {
                endofWord = true;
                return;
            }

            if (hasChild(s[0])) {
                getChild(s[0]).addWord(s.Remove(0, 1), this.getChild(s[0]));
            }

            if (!hasChild(s[0])) {
                children.Add(s[0], new TreeNode(s[0], false));
                getChild(s[0]).addWord(s.Remove(0, 1), this.getChild(s[0]));

            }
        }


        public TreeNode addChar(Char c) {
            if (!hasChild(c)) {
                children.Add(c, new TreeNode(c, false));
                return children[c];
            } else return children[c];
        }
    }
}

