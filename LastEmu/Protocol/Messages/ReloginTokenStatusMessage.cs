using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ReloginTokenStatusMessage : NetworkMessage
	{
		public const uint Id = 6539;

		public bool validToken;

		public sbyte[] ticket;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6539;
			}
		}

		public ReloginTokenStatusMessage()
		{
		}

		public ReloginTokenStatusMessage(bool validToken, sbyte[] ticket)
		{
			this.validToken = validToken;
			this.ticket = ticket;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.validToken = reader.ReadBoolean();
			ushort num = (ushort)reader.ReadVarInt();
			this.ticket = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				this.ticket[i] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.validToken);
			writer.WriteVarInt((int)((int)this.ticket.Length));
			sbyte[] numArray = this.ticket;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteSByte(numArray[i]);
			}
		}
	}
}