using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class IdolListMessage : NetworkMessage
	{
		public const uint Id = 6585;

		public uint[] chosenIdols;

		public uint[] partyChosenIdols;

		public PartyIdol[] partyIdols;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6585;
			}
		}

		public IdolListMessage()
		{
		}

		public IdolListMessage(uint[] chosenIdols, uint[] partyChosenIdols, PartyIdol[] partyIdols)
		{
			this.chosenIdols = chosenIdols;
			this.partyChosenIdols = partyChosenIdols;
			this.partyIdols = partyIdols;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.chosenIdols = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.chosenIdols[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.partyChosenIdols = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.partyChosenIdols[j] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.partyIdols = new PartyIdol[num];
			for (int k = 0; k < num; k++)
			{
				this.partyIdols[k] = ProtocolTypeManager.GetInstance<PartyIdol>(reader.ReadUShort());
				this.partyIdols[k].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.chosenIdols.Length));
			uint[] numArray = this.chosenIdols;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.partyChosenIdols.Length));
			uint[] numArray1 = this.partyChosenIdols;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarShort((int)numArray1[j]);
			}
			writer.WriteShort((short)((int)this.partyIdols.Length));
			PartyIdol[] partyIdolArray = this.partyIdols;
			for (int k = 0; k < (int)partyIdolArray.Length; k++)
			{
				PartyIdol partyIdol = partyIdolArray[k];
				writer.WriteShort(partyIdol.TypeId);
				partyIdol.Serialize(writer);
			}
		}
	}
}