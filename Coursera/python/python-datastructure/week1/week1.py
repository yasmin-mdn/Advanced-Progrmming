text = "X-DSPAM-Confidence:    0.8475"
pos=text.find(':')
st=text[pos+1:]
st=st.strip()
print(float(st))